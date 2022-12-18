using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float time;
    private bool turnRight;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        turnRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(turnRight) {
            if (time < 6) {
                transform.Rotate(Vector3.up * Time.deltaTime * 15f);
            } else {
                time = 0;
                turnRight = false;
            }
        } else {
            if (time < 6) {
                transform.Rotate(Vector3.up * Time.deltaTime * -15f);
            } else {
                time = 0;
                turnRight = true;
            }
        }
    }
}
