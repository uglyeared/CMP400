using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    private bool hit = false;
    private GameObject switchObj;
    public float switchMoveDistance;
    private float switchMoveSpeed = 0.001f;
    private float switchPos;
    private bool switchState;
    private float hitTimer;
    public float hitTime;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        switchObj = transform.GetChild(1).gameObject;
        switchPos = switchObj.transform.position.y;
        switchState = false;
    }

    // Update is called once per frame
    void Update()
    {




        if (hit == true && switchState == false)
        {
            hit = false;
            switchState = true;
            switchObj.transform.position = new Vector3(switchObj.transform.position.x, switchObj.transform.position.y, switchObj.transform.position.z - switchMoveDistance);
        }
        else if(hit == true && switchState == true)
        {
            hit = false;
            switchState = false;
            switchObj.transform.position = new Vector3(switchObj.transform.position.x, switchObj.transform.position.y, switchObj.transform.position.z + switchMoveDistance);
        }


            hitTimer -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit0");
        Debug.Log(other.name);
        if (other.CompareTag("hand") && switchState == false && hitTimer < 0)
        {
            hitTimer = hitTime;
            hit = true;
            Values.setDummy = false;
            Debug.Log("hit1");
        }else if (switchState == true)
        {
            hitTimer = hitTime;
            hit = true;
            Values.setDummy = true;
            Debug.Log("hit1");
        }
    }
}
