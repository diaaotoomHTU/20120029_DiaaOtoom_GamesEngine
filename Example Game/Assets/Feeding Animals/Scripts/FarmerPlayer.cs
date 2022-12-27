using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerPlayer : MonoBehaviour
{

    [SerializeField] GameObject[] food;
    [SerializeField] Transform spawnPoint;
    GameObject clone;
    float speed = 0.15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Input.GetAxis("Vertical") * speed;
        float horizontalMovement = Input.GetAxis("Horizontal") * speed;
        Vector3 movement = Vector3.forward * verticalMovement + Vector3.right * horizontalMovement;
        this.transform.Translate(movement);
        Vector3 newPosition = this.transform.position + movement;
        newPosition.x = Mathf.Clamp(newPosition.x, -15, 15);
        newPosition.z = Mathf.Clamp(newPosition.z, -0, 15);
        this.transform.position = newPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            clone = Instantiate(food[Random.Range(0, 6)], spawnPoint.position, Quaternion.identity);
            clone.GetComponent<Rigidbody>().AddForce(0, 0, 500);
        }
    }
}
