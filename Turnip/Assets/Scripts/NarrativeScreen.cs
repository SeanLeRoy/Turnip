using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NarrativeScreen : MonoBehaviour
{
    public Canvas canvas;
    public GameObject parkerPrefab;
    public GameObject otherSpeakerPrefab;
    public NarrativeDialogue narrativeDialogue;

    private int index;

    public void Start()
    {
        CreateNextDialogue();
    }

    public void CreateNextDialogue() {
        if (narrativeDialogue.HasNextDialogue())
        {
            Dialogue nextDialogue = narrativeDialogue.GetNextDialogue();
            GameObject prefab;
            if (nextDialogue.name.Contains("Parker")) {
                prefab = parkerPrefab;
            } else {
                prefab = otherSpeakerPrefab;
            }
            GameObject newBox = Instantiate(prefab, new Vector3(0, 100, 0), Quaternion.identity);
            newBox.name = newBox.name + index;
            index++;
            newBox.transform.parent = canvas.transform; // perhaps snap the transform to the lower right corner?

            FindObjectOfType<DialogueManager>().StartDialogue(nextDialogue, newBox);
        } else {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
