using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class ReadToggleInput : MonoBehaviour
{

    static bool toggleVal;
    public Toggle toggle;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ToggleFlipped()
    {

        //toggleVal = toggle.isOn;
        Debug.Log(toggle.isOn);

         if (toggle.isOn ) { Values.enemyStatus = true; }else { Values.enemyStatus = false; }
    }
}
