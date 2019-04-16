using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public GameObject backgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(backgroundMusic);
    }
}
