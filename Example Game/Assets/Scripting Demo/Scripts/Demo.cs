using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{

    Rigidbody rb;
    bool flag;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            rb.AddForce(0, 0, 1);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(false);
        // flag = true;
    }


    private void OnCollisionStay(Collision collision)
    {
        print("CollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        flag = false;
        rb.position = startPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        print("TriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        print("TriggerStay");
    }


    private void OnTriggerExit(Collider other)
    {
        print("TriggerExit");
    }
}
