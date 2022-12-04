using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    bool gameStart = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(-5, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Road") && gameStart)
        {
            this.GetComponent<AudioSource>().Play();
            gameStart = false;
        }
    }
}
