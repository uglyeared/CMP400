using UnityEngine;
using UnityEngine.UI;
public class ReadSliderInput : MonoBehaviour
{


    public Slider slider;
    static float sliderVal;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScrollValChanged()
    {
        sliderVal = slider.value;
        Debug.Log(sliderVal);
        Values.enemySpeed = sliderVal*2;
    }
}
