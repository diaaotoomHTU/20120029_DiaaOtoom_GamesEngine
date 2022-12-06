using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject car;
    bool thirdPerson = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            thirdPerson = !thirdPerson;
        }
        if (thirdPerson)
        {
            this.transform.position = car.transform.position + new Vector3(0, 4, -7);
            this.transform.rotation = Quaternion.Euler(20, 0, 0);
        } else
        {
            this.transform.position = car.transform.position + new Vector3(0, 2, 1);
            this.transform.rotation = car.transform.rotation;
        }
    }
}
