using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//класс для управления настройками звука
public class Settings : MonoBehaviour
{
    public Slider sliderV;

    void Start()
    {
        sliderV.value = AudioListener.volume;

    }
    public void SetSound()
    {
        if (gameObject.GetComponent<Toggle>().isOn == true)
        {
            AudioListener.volume = sliderV.value;

        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}
