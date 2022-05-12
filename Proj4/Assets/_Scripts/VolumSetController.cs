using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumSetController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private Text volumeText = null;
    
    private void Start(){
        LoadValue();
    }
    public void VolumSlider(float volume){
        volumeText.text = volume.ToString("0.0");
    }

    public void SaveVolum(){
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("volumeValue",volumeValue);
        LoadValue();
    }

    void LoadValue(){
        float volumeValue = PlayerPrefs.GetFloat("volumeValue");
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
    
}
