using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonPlayer : MonoBehaviour
{
    public GameObject cannonBall;
    public Transform shootingEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shotBall = Instantiate(cannonBall, shootingEnd.position, Quaternion.identity);
            shotBall.GetComponent<Rigidbody>().AddForce(0, 300, 300);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, -0.01f, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0.01f, 0, Space.World);
        }
    }
}
