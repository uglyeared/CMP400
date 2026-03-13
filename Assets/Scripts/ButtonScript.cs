using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    private bool hit = false;
    private GameObject button;
    public float btnMoveDistance;
    private float btnMoveSpeed = 0.001f;
    private float btnPos;
    private float hitTimer;
    public float hitTime;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        button = transform.GetChild(1).gameObject;
        btnPos = button.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {

        if (hit == true)
        {
            hit = false;
            button.transform.position = new Vector3(button.transform.position.x, button.transform.position.y - btnMoveDistance, button.transform.position.z);
        }
        if (button.transform.position.y < btnPos)
        {
            button.transform.position += new Vector3(0, btnMoveSpeed, 0);
        }

        hitTimer -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit0");
        Debug.Log(other.name);
        if (other.CompareTag("hand")&& hitTimer < 0)
        {
            hitTimer = hitTime;
            hit = true;
            Values.spawnDummy = true;
            Debug.Log("hit1");
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    GameObject collisionITem = collision.gameObject;
    //    Debug.Log("hit0");
    //    if (collisionITem.CompareTag("hand"))
    //    {                     
    //            hitTimer = hitTime;
    //            hit = true;
    //            Debug.Log("hit1");
    //    }
    //}
}

