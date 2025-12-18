using System.Data.Common;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class SimpleMoveNew : MonoBehaviour {
    public float baseSpeed = 5f;
    public float speedMultiplier = 1.7f;

    void Update() {
        if (Keyboard.current == null) return;

        Vector3 input = Vector3.zero;

        if (Keyboard.current.wKey.isPressed) input += Vector3.forward;
        if (Keyboard.current.sKey.isPressed) input += Vector3.back;
        if (Keyboard.current.dKey.isPressed) input += Vector3.right;
        if (Keyboard.current.aKey.isPressed) input += Vector3.left;
        //if (Keyboard.current.rKey.isPressed)

        float currentSpeed = baseSpeed;

        if (Keyboard.current.leftShiftKey.isPressed) currentSpeed *= speedMultiplier;

        transform.Translate(input.normalized * currentSpeed * Time.deltaTime);
    }
}