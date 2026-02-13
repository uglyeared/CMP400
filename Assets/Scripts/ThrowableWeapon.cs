using UnityEngine;

public class ThrowableWeapon : MonoBehaviour
{

    public int WeaponType; //to be changed by use of ui
    public bool WeaponSide;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { }
   
    


    // Update is called once per frame
    void Update()
    {
        
    }

    void onSliderSwitch()
    {


        switch (WeaponType)
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
        WeaponSide = true;
    }
    void bottleType2()
    {
        WeaponSide = true;

    }
    void bottleType3()
    {
        WeaponSide = false;

    }
    
}






  