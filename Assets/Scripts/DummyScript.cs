using System.ComponentModel.Design;
using UnityEngine;

public class DummyScript : MonoBehaviour
{

    int Health;
    bool Defending;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = 50;
        Defending = false; //set by ui, changes between attacking enemy & target dummy with no attack

    }

    // Update is called once per frame
    void Update()
    {


        if (Health == 0 & Defending == true)
        {
            //kill self
            object obj = null;
        }
        else
        {
            Health += 50;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collisionITem = collision.gameObject;
        if (collisionITem.CompareTag("bottle1"))
        {
            Debug.Log("type1");

        }
        else if (collisionITem.CompareTag("bottle2"))
        {
            Debug.Log("type1");
        }
        else
        {
            Debug.Log("type1");
        }
    }
}
