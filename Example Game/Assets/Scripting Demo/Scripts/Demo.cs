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
        flag = false;
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
        flag = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Yellow"))
        {
            other.gameObject.SetActive(false);
        }
    }

}
