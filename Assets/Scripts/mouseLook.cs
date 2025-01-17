using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//mouseLook script:
// locks the camera to the player's mouse
// player controls character through first player behavior

public class mouseLook : MonoBehaviour
{
    // Start is called before the first frame update

    public float mouseSensitivity = 100f;

    public Transform playerBody;
    
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    // mouseX & mouseY are the player's inputs
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
