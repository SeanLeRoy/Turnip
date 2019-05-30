using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Animator animator;

    public NarrativeScreen narrativeScreen;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue) {
        animator.SetBool("IsOpen", true);

        //Time.timeScale = 0f; // stops the game
        nameText.text = dialogue.name;

        sentences.Clear();
        foreach(string sentence in  dialogue.sentences) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence(sentences);
    }

    public void StartDialogue(Dialogue dialogue, GameObject dialogueBoxPrefab)
    {
        animator = dialogueBoxPrefab.GetComponent<Animator>();

        nameText = GameObject.Find(dialogueBoxPrefab.name + "/Name").GetComponent<TextMeshProUGUI>();
        dialogueText = GameObject.Find(dialogueBoxPrefab.name + "/Dialogue").GetComponent<TextMeshProUGUI>();

        animator.SetBool("IsOpen", true);

        //Time.timeScale = 0f; // stops the game
        nameText.text = dialogue.name;

        sentences = new Queue<string>();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence(sentences);
    }

    public void DisplayNextSentence(Queue<string> lines) {
        if (lines.Count == 0) {
            EndDialogue();
            return;
        }
        string sentence = lines.Dequeue();
        StopAllCoroutines(); // prevent multiple animations
        StartCoroutine(TypeSentence(sentence, lines));
    }

    IEnumerator TypeSentence(string sentence, Queue<string> lines) {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
        yield return new WaitForSeconds(2);
        DisplayNextSentence(lines);
    }

    public void EndDialogue() {
        //Time.timeScale = 0f; // resumes the game
        animator.SetBool("IsOpen", false);
        if (narrativeScreen)
        {
            StartCoroutine(PrepareNextDialogue());
        }
    }

    IEnumerator PrepareNextDialogue() {
        yield return new WaitForSeconds(5);
        animator.SetBool("FloatUp", true);
        narrativeScreen.CreateNextDialogue();
    }
}
