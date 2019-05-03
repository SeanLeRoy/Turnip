using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScreenResolution : MonoBehaviour
{
    Dropdown m_Dropdown;
    public Dropdown Resolution;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(640, 480, true);
        Debug.Log("testing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
