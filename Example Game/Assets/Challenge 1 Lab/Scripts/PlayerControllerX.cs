using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject obstacles;
    Vector3 instantiatePos;
    float speed;
    float rotationSpeed;
    float verticalInput;
    bool inverse = false;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.4f;
        rotationSpeed = 50;
        instantiatePos = new Vector3(0, 0, 200);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        if (inverse)
        {
            verticalInput = -verticalInput;
        }

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * -rotationSpeed * Time.deltaTime * verticalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Accelerate"))
        {
            speed = 0.6f;
        } else if (other.gameObject.CompareTag("Decelerate")) {
            speed = 0.2f;
        } else if (other.gameObject.CompareTag("Inverse"))
        {
            inverse = true;
        } else if (other.gameObject.CompareTag("Score Gate"))
        {
            ++Score.gateScore;
            print(Score.gateScore);
        } else if (other.gameObject.CompareTag("Instantiate Gate"))
        {
            Instantiate(obstacles, instantiatePos, Quaternion.identity);
            instantiatePos = new Vector3(0, 0, instantiatePos.z + 200);
        }
        other.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("Obstacle"))
        {
            this.transform.position = Vector3.zero;
        }
    }
}
