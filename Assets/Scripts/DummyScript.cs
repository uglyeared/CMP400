using System.ComponentModel.Design;
using UnityEngine;

public class DummyScript : MonoBehaviour
{

    public int Health;
    public bool Defending;
    public GameObject pointA;
    public GameObject pointB;
    private Transform pointAs;
    private Transform pointBs;
    private Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = 50;
        
        pointAs = pointA.GetComponent<Transform>();
        pointBs = pointB.GetComponent<Transform>();
        target = pointAs;

        Defending = Values.setDummy;


    }

    // Update is called once per frame
    void Update()
    {
        if (Values.setDummy)
        {
            Defending = true;
        }
        else
        {
            Defending = false;
        }

        if (Health <= 0)
        {
            //kill self

            Destroy(gameObject);
        }
        else
        {
            //Health += 50;
        }

        if (Defending)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Values.enemySpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                target = (target == pointAs) ? pointBs : pointAs;
            }
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
