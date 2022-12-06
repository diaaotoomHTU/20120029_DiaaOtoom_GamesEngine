using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().centerOfMass = new Vector3(0, 0.5f, -0.36f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddRelativeForce(0, 0, 500);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -0.5f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 0.5f, 0);
        }
    }
}
