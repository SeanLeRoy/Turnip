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
    }

    // Update is called once per frame
    void Update()
    {
        int value = Resolution.value;

        if(value == 0)
        {
            Screen.SetResolution(1024, 546, false);
        } else if (value == 1)
        {
            Screen.SetResolution(1152, 648, false);
        } else
        {
            Screen.SetResolution(1280, 720, false);
        }
    }
}
