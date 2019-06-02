using UnityEngine;

class PowerUpSpeed : MonoBehaviour
{
    private AudioSource audioSource;
    private AudioClip chestSound;

	private void Start()
	{
        audioSource = gameObject.AddComponent<AudioSource>();
        chestSound = Resources.Load<AudioClip>("Assets/Props/Game Music/DamageGiven.mp3");
        Debug.Log(chestSound);
	}

	void OnTriggerEnter2D(Collider2D other) 
    {
        PlayerMovement player = GameObject.Find("Parker").GetComponent<PlayerMovement>();
        player.speedMod = 2;
        GameObject chest = GameObject.Find("chest");
        audioSource.clip = chestSound;
        audioSource.Play();
        gameObject.GetComponent<Renderer>().enabled = false;
    }
}
