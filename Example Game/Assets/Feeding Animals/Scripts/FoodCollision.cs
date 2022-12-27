using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Slider hungerBar = collision.gameObject.transform.parent.Find("HungerCanvas").transform.Find("Hunger Bar").GetComponent<Slider>();
        hungerBar.value += 0.5f;
        if (hungerBar.value == 1)
        {
            ++FeedingAnimalsGameManager.score;
            print(FeedingAnimalsGameManager.score);
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
        Destroy(this.gameObject);
    }
}
