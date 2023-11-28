using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public Transform player;
    public float mouseSensitivity = 2f;
    float cameraVerticalRotation = 0f;

    bool lockedCursor = true;

    void start()
    {

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    void update()
    {

        float inputX = Input.GetAxis("Mouse X")*mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y")*mouseSensitivity;

        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        player.Rotate(Vector3.up * inputX);
    }

//    public Transform target;
//    public float followDistance = 8f;
//    public float cameraSpeed = 3f;

//    private void LateUpdate()
//    {
//        float newRotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * cameraSpeed;
//        float newRotationY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * cameraSpeed;
//
//        Vector3 desiredRotation = new Vector3(newRotationY, newRotationX, 0f);
//        transform.localEulerAngles = desiredRotation;

//        Vector3 desiredPosition = target.position - transform.forward * followDistance;
//        transform.position = desiredPosition;
//    }
}
