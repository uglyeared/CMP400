using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnItem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(spawnItem);
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(spawnItem);
    }
}
