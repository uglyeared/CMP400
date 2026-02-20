using UnityEngine;

public class ThrowableWeapon : MonoBehaviour //to decide which type of throwable weapon is to be used. used at the moment of switching the slider inside of the ui. 
{

    public int weaponType=1; //to be changed by use of ui
    public bool weaponSide=true;//true for damaging weapons false for healing

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {       
        weaponType = Random.Range(1,4);


        switch (weaponType)
        {
            case 1:
                bottleType1();
                gameObject.tag = "type1";
                Debug.Log("1");
                break;
            case 2:
                bottleType2();
                gameObject.tag = "type2";
                Debug.Log("1");
                break;
            case 3:
                bottleType3();
                gameObject.tag = "type3";
                Debug.Log("1");
                break;
        }

    }

    


    // Update is called once per frame
    void Update()
    {
        
    }

    void onSliderSwitch()
    {


        switch (weaponType)
        {
            case 1:
                bottleType1();
                break;
            case 2:
                bottleType2();
                break;
            case 3:
                bottleType3();
                break;
        }


    }


    void bottleType1()
    {
        //WeaponSide = true;
    }
    void bottleType2()
    {
        //WeaponSide = true;

    }
    void bottleType3()
    {
        //WeaponSide = false;

    }
    
}






  