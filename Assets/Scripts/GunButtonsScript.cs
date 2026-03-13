using NUnit.Framework;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class GunButtonsScript : MonoBehaviour
{
    private bool hit = false;
    //private GameObject button;
    public float btnMoveDistance;
    private float btnMoveSpeed = 0.001f;
    private List<float> btnPos = new List<float>(2);
    private float hitTimer;
    public float hitTime;
    public GameObject gun;
    private Vector3 startPos;
    private List<GameObject> buttons = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        foreach (Transform btnTransform in gun.transform)
        {
            buttons.Add(btnTransform.gameObject);
            Debug.Log($"Found {buttons.Count} direct children.");
        }
        for (int i = 0; i < buttons.Count; i++)
        {
            gun = transform.GetChild(i).gameObject;
            startPos = gun.transform.localPosition;


        }
    }

    // Update is called once per frame
    void Update()
    {

        if (hit == true && hitTimer<0)
        {

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].transform.position = startPos;

                if (buttons[i].CompareTag("button1") && Values.buttonPressed == 1)
                {
                    buttons[i].transform.position = new Vector3(buttons[i].transform.position.x, buttons[i].transform.position.y, buttons[i].transform.position.z - btnMoveDistance);
                    hitTimer = hitTime;
                    hit = true;
                    Values.weaponType = 1;
                    Debug.Log("hit1");

                }
                else if (buttons[i].CompareTag("button2") && Values.buttonPressed == 2)
                {
                    buttons[i].transform.position = new Vector3(buttons[i].transform.position.x, buttons[i].transform.position.y, buttons[i].transform.position.z - btnMoveDistance);
                    hitTimer = hitTime;
                    hit = true;
                    Values.weaponType = 2;
                    Debug.Log("hit2");
                }
                else if (buttons[i].CompareTag("button3") && Values.buttonPressed == 3)
                {
                    buttons[i].transform.position = new Vector3(buttons[i].transform.position.x, buttons[i].transform.position.y, buttons[i].transform.position.z - btnMoveDistance);
                    hitTimer = hitTime;
                    hit = true;

                    Values.weaponType = 3;
                    Debug.Log("hit3");
                }

            }

            hitTimer -= Time.deltaTime;
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{

    //    Collider pressed = Values.currentlyTouching;
       

    //    Debug.Log("hit0");
    //    Debug.Log(other.name);


    //    if (other.CompareTag("Lhand") && hitTimer < 0 && pressed.CompareTag("button1"))
    //    {
    //        hitTimer = hitTime;
    //        hit = true;
    //        Values.weaponType = 1;
    //        Debug.Log("hit1");
    //    }
    //    else if (other.CompareTag("Lhand") && hitTimer < 0 && pressed.CompareTag("button2"))
    //    {
    //        hitTimer = hitTime;
    //        hit = true;
    //        Values.weaponType = 2;
    //        Debug.Log("hit2");
    //    }
    //    else if (other.CompareTag("Lhand") && hitTimer < 0 && pressed.CompareTag("button3"))
    //    {
    //        hitTimer = hitTime;
    //        hit = true;
            
    //        Values.weaponType = 3;
    //        Debug.Log("hit3");
    //    }

    //}
}
