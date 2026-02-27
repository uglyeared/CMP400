using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
public class ReadUIInput : MonoBehaviour
{

    public GameObject toggle;
    public Slider slider;
    static float sliderVal;


    public Dropdown ddOpt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DDValueChanged() {


        int meow = ddOpt.value;
        {
            Debug.Log(meow);
        }
        ;

    }

    public void ToggleFlipped()
    {
        Debug.Log("meow");

    }

    public void SliderValChanged()
    {
        sliderVal = slider.value;
        Debug.Log(sliderVal);
        Values.weaponType = sliderVal;
    }
}
