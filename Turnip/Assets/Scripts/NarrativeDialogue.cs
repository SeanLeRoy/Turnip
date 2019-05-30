using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NarrativeDialogue
{
    public Dialogue[] dialogues;

    private int index;

    public Dialogue GetNextDialogue() {
        if (!HasNextDialogue()) {
            Debug.Log("NO DIALOGUES TO MAKE YET ATTEMPTED");
        }
        index += 1;
        return dialogues[index - 1];
    }

    public bool HasNextDialogue() {
        return index < dialogues.Length;
    }
}