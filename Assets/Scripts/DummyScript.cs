using System.ComponentModel.Design;
using UnityEngine;

public class DummyScript : MonoBehaviour
{

    public int Health;
    public bool Defending;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = 50;
        Defending = false; //set by ui, changes between attacking enemy & target dummy with no attack

    }

    // Update is called once per frame
    void Update()
    {


        if (Health <= 0)
        {
            //kill self
           
            Destroy(gameObject);
        }
        else
        {
            //Health += 50;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collisionITem = collision.gameObject;

        if (collisionITem.CompareTag("type1"))
        {
            Debug.Log("type1");
            Health -= 20;
            Debug.Log(Health);

        }
        else if (collisionITem.CompareTag("type2"))
        {
            Debug.Log("type2");
           
            Health -= 50;
            Debug.Log(Health);
        }
        else if (collisionITem.CompareTag("type3"))
        {
            Debug.Log("type3");
            if (Health > 30)
            {
                Health = 50;
            }
            else { Health += 20; }
            Debug.Log(Health);
        }
    }
}
