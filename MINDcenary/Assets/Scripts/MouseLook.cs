using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public Transform camera;
    public float MouseSensi = 100f;
    float xRotation = 0f;
    float mouseX;
    float mouseY;
    float mouseinputx;
    float mouseinputy;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // float mouseX = Input.GetAxis("Mouse X") * MouseSensi * Time.deltaTime;

        mouseX = mouseinputx * MouseSensi * Time.deltaTime;
        // float mouseY = Input.GetAxis("Mouse Y") * MouseSensi * Time.deltaTime;

        mouseY = mouseinputy * MouseSensi * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        camera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);

        if (Application.platform == RuntimePlatform.Android)
        {
            MouseSensi = 120;
        }
        
    }

    public void OnLookEvent(InputAction.CallbackContext value)
    {
        mouseinputx = value.ReadValue<Vector2>().x;
        mouseinputy = value.ReadValue<Vector2>().y;
    }
}
