using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SeekAndFlee : MonoBehaviour
{
    public float maxSpeed;

    public Transform target;
    public bool seek = true;

    public void Start()
    {
        target = GameObject.Find("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        // move me
        Vector3 v = (target.position - transform.position).normalized * maxSpeed;
        if (seek)
        {
            transform.position += v * Time.deltaTime;
        }
        else
        {
            transform.position -= v * Time.deltaTime;
        }
        // face my target
        transform.LookAt(target);
    }
}

