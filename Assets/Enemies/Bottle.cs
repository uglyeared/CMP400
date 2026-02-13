using UnityEngine.Events;
using UnityEngine;

[CreateAssetMenu(fileName = "Bottle", menuName = "Scriptable Objects/Bottle")]

public class Bottle : ScriptableObject
{

    public int WeaponType; //to be changed by use of ui
    public bool WeaponSide;



    void onThrow()
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