using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using Fungus;

[RequireComponent(typeof(Slider))]
public class Volume_Slider : MonoBehaviour
{
    public float provar = 15.0f;

    Slider slider
    {
        get 
        { 
            return GetComponent<Slider>();
        }
    }
    
    public AudioMixer mixer;
    public string sliderName;
    

    public void UpdateValueChange()
    {
        Debug.Log("el slider es "+slider.value);
        float value = slider.value;
        mixer.SetFloat(sliderName, value);
    }
    public void volum()
    {

    }


      // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }
/*
    // Update is called once per frame
    void Update()
    {
      Debug.Log("el valor es " + provar);
        mixer.SetFloat(sliderName, value);
    }*/
}
