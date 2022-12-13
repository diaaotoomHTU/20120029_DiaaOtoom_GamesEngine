using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{
    [SerializeField] int foodScore;
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
        if (this.gameObject.CompareTag(collision.gameObject.transform.parent.gameObject.tag))
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
        Destroy(this.gameObject);
    }
}
