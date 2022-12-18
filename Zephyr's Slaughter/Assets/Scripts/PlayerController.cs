using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1f;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 moveDirection;
    private Rigidbody rigidBody;

    void Start() {
        rigidBody = gameObject.GetComponent<Rigidbody>();
        rigidBody.freezeRotation = true;
    }

    void Update() {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        moveDirection = gameObject.transform.forward * verticalInput + gameObject.transform.right * horizontalInput;

        rigidBody.AddForce(moveDirection.normalized * moveSpeed * 8f, ForceMode.Force);
    }
}
