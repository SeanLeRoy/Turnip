using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    public Slider Volume;
    public AudioSource GameMusic;
    public Toggle FullScreen;

	void Start()
	{
        GameObject backgroundMusic = GameObject.Find("BackgroundMusic");
        GameMusic = backgroundMusic.GetComponent<AudioSource>();
	}

	public void ToggleFullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    // Update is called once per frame
    void Update()
    {
        GameMusic.volume = Volume.value;
    }
}