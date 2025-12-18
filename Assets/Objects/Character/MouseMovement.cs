using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseMovement : MonoBehaviour {
    
    public Transform CameraPvoit;
    public float mouseSensitivity = 100f;
    float xRotation = 0f;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update() {
        if (Mouse.current == null) return;

        float MouseX = Mouse.current.delta.x.ReadValue() * mouseSensitivity * Time.deltaTime;
        float MouseY = Mouse.current.delta.y.ReadValue() * mouseSensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * MouseX);

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -80, 50);

        CameraPvoit.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }
}
