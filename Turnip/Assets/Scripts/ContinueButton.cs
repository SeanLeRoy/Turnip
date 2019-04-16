using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{

    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        if (!SaveSystem.PlayerFileExists()) {
            button.SetActive(false);
        }
    }
}
