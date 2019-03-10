using UnityEngine;
using UnityEngine.UI;

public class ToggleMusic : MonoBehaviour
{
    Toggle m_Toggle;
    public Slider Volume;

    void Start()
    {
        //Fetch the Toggle GameObject
        m_Toggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, and output the state
        m_Toggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(m_Toggle);
        });
    }

    //Output the new state of the Toggle into Text when the user uses the Toggle
    void ToggleValueChanged(Toggle change)
    {
        if (!m_Toggle.isOn) {
            Volume.value = 0;
            Volume.transform.gameObject.SetActive(false);
        } else {
            Volume.transform.gameObject.SetActive(true);
        }
    }
}
