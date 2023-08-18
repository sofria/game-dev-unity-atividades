using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{

    public float speed;
    public Vector2 finalPosition;
    public GameObject objectToSpawn;


    void Start()
    {
        
        
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, finalPosition, speed * Time.deltaTime);

        if (Input.GetKeyDown("c"))
        {
            Instantiate(objectToSpawn);
        }
        if(Input.GetKeyDown("d"))
        {
            Destroy(objectToSpawn);
        }
    }
}
