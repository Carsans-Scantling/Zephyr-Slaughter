using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float mouseSense = 400f;
    public GameObject playerObj;
    private float xRotation = 0f;
    private float yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSense * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSense * Time.deltaTime;

        xRotation -= mouseY;
        yRotation += mouseX;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        gameObject.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        playerObj.transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
