using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetData : MonoBehaviour
{
    public Slider slider;
    public Text sliderValue;
    // Start is called before the first frame update
    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 120;
        slider.value = 30;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeSlider()
    {
        int x = (int)slider.value;
        sliderValue.text = "Value " + x;
    }
}
