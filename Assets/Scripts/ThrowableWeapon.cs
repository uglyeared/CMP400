using JetBrains.Annotations;
using System.ComponentModel;
using UnityEngine;

public class ThrowableWeapon : MonoBehaviour //to decide which type of throwable weapon is to be used. used at the moment of switching the slider inside of the ui. 
{
    public ReadUIInput input;
    public float weaponType=1; //to be changed by use of ui
    public bool weaponSide=true;//true for damaging weapons false for healing
    public float force=100;
    public float destructionTimer = 5;
    Rigidbody rigidbody;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
        rigidbody = GetComponent<Rigidbody>();
      
        rigidbody.AddForce(transform.forward * force);

        weaponType = Values.weaponType;

       // weaponType= ReadUIInput.com

        switch (weaponType)
        {
            case 1:
                
                gameObject.tag = "type1";
              
               
                Debug.Log("1");
                break;
            case 2:
              
                gameObject.tag = "type2";
                
                Debug.Log("2");
                break;
            case 3:
            
                gameObject.tag = "type3";
               
                Debug.Log("3");
                break;
        }

    }

    


    // Update is called once per frame
    void Update()
    {
        destructionTimer -= Time.deltaTime;
        if (destructionTimer <= 0)
        {
            Destroy(gameObject);
        }
    }

    void onSliderSwitch()
    {


       


    }

    
}






  