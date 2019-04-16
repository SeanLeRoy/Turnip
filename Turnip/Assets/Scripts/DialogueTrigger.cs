using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private bool dialogueTriggered;

	public void Start()
	{
        dialogueTriggered = false;
	}

	public void TriggerDialogue() {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

	public void OnTriggerEnter2D(Collider2D collision)
	{
        // trigger dialogue
        if (!dialogueTriggered) {
            dialogueTriggered = true;
            TriggerDialogue();
        }
	}

	public void OnTriggerStay2D(Collider2D collision)
    {
        // could add hover or float effects to objects!
    }

	public void OnTriggerExit2D(Collider2D collision)
	{
		// nah
	}
}
