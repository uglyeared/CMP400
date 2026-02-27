using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAdds : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform bulletSpawn;
    public float shotFrequency = 0.5f;
    float lastShot;

    public InputActionReference shoot;
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
    }
}
