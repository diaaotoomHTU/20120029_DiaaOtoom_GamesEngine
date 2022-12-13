using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedingAnimalsDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > 30 || this.transform.position.z < -15)
        {
            Destroy(this.gameObject);
        }
    }
}
