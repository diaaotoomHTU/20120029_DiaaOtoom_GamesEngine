using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    Vector3 startPos;
    float hor;
    float ver;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.transform.position = startPos;
        }
        rb.AddForce(hor, 0f, ver);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            GameManager.score += 5;
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("Cube")) 
        {
            ++GameManager.score;
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("Water"))
        {
            this.transform.position = startPos;
        }
        
        print(GameManager.score);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Jump Pad"))
        {
            rb.AddForce(0f, 500f, 0f);
        }   
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, 300f, 0);
        }
    }
}
