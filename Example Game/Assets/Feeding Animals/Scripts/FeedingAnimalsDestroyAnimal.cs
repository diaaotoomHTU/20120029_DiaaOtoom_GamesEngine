using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedingAnimalsDestroyAnimal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > 30 || this.transform.position.z < -15 || this.transform.position.x > 20 || this.transform.position.x < -20)
        {
            Destroy(this.gameObject);
            --FeedingAnimalsGameManager.score;
            print(FeedingAnimalsGameManager.score);
        }
    }
}
