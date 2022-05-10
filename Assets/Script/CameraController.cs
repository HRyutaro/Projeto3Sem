using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public static bool lockCursor;
    public Transform target;
    public float mouseSensivity = 10;
    public float distanceFromTarget = 2;
    public Vector2 pitchMinMax = new Vector2(-40, 85);

    public float rotationSmoothtime = .12f;
    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    float yaw;
    float pitch;

    //ajuste da parede
    RaycastHit hit = new RaycastHit();
    public float ajusteCamera;

    void Start()
    {
        lockCursor = true;
    }


    void LateUpdate()
    {
        if(lockCursor == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if(lockCursor == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if(lockCursor == true)
        {
            yaw += Input.GetAxis("Mouse X") * mouseSensivity;
            pitch -= Input.GetAxis("Mouse Y") * mouseSensivity;
            pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

            currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothtime);
            transform.eulerAngles = currentRotation;
            transform.position = target.position - transform.forward * distanceFromTarget;

            //ajuste da parede
            if(Physics.Linecast(target.position, transform.position, out hit))
            {
                transform.position = hit.point + transform.forward * ajusteCamera;
            }

        }

    }
}
