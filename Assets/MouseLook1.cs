using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook1 : MonoBehaviour
{
    public float mouseSensitivity = 100F;

    public Transform playerBody;

    float xRotation = 0F;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90F, 90F);

        transform.localRotation = Quaternion.Euler(xRotation, 0F, 0F);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
