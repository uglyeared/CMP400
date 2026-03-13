using UnityEngine;

public class TouchDetect : MonoBehaviour
{

   public GameObject button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //    private void OnCollisionEnter(Collision collision)
    //    {
    //        if (button.CompareTag("button1"))//&&other.CompareTag("Lhand"))
    //        {
    //            Values.buttonPressed = 1;

    //        }


    //        else if (button.CompareTag("button2"))//&& other.CompareTag("Lhand"))
    //        {
    //            Values.buttonPressed = 2;
    //        }
    //        else if (button.CompareTag("button3"))//&& other.CompareTag("Lhand"))
    //        {
    //            Values.buttonPressed = 3;
    //        }
    //    }

    //}
    private void OnTriggerEnter(Collider other)
    {
        if (button.CompareTag("button1"))//&&other.CompareTag("Lhand"))
        {
            Values.buttonPressed = 1;

        }


        else if (button.CompareTag("button2"))//&& other.CompareTag("Lhand"))
        {
            Values.buttonPressed = 2;
        }
        else if (button.CompareTag("button3"))//&& other.CompareTag("Lhand"))
        {
            Values.buttonPressed = 3;
        }
    }
}


