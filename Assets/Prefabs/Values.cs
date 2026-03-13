using UnityEngine;

[CreateAssetMenu(fileName = "Values", menuName = "Scriptable Objects/Values")]
public static class Values
{
    public static float weaponType;
    public static bool enemyStatus;
    public static float enemySpeed =0.5f;
    public static bool spawnDummy = false;
    public static Collider currentlyTouching;
    public static bool setDummy;
    public static int buttonPressed;
}
