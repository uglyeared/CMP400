using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAdds : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform bulletSpawn;
    public float shotFrequency = 0.5f;
    float lastShot;


    float currentAngle;
    float x;
    float y;

    public InputActionReference shoot;
    public InputActionReference selectRotary;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       
        if (shoot.action.ReadValue<float>() == 1 && lastShot <= 0) 
        {

            Instantiate(projectilePrefab, bulletSpawn.position, bulletSpawn.rotation);
            lastShot = shotFrequency;
        }
        lastShot -= Time.deltaTime;

        //currentAngle = selectRotary.action.ReadValue<float>();
        //x = Input.GetAxis("JoystickX");
        //y = Input.GetAxis("JoystickY");
        //currentAngle = Mathf.Atan2(x, y) * Mathf.Rad2Deg;
        //Debug.Log(currentAngle);

    }
   

}
