using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public static BackgroundMusic instance;

    public AudioSource audioSource;


    private bool SongLoaded;


    void Awake()
    {
        MakeSingleton();
        audioSource = GetComponent<AudioSource>();
    }

    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayMusic(bool play)
    {
        if (play)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
            }
            audioSource.Stop();
        }

    }


    //private GameObject backgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(instance);
    }
}
