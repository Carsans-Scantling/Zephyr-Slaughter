using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //Physics.IgnoreCollision(gameObject.GetComponent<Rigidbody>(), player.GetComponent<Rigidbody>(), true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("Collision!");
        if (other.gameObject.tag == "EnemyHitbox") {
            Debug.Log("Collision with tag");
            Destroy(other.transform.parent.gameObject);
        }
    }
}
