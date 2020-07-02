using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class AccelerometerCamera : MonoBehaviour
{
    Camera cam;
    [SerializeField]
    Transform cameraRotationCenter;
    [SerializeField]
    float rotationAngleForce = 25;
    [SerializeField] bool arrowInput;

    private void Start()
    {        
        cam = GetComponent<Camera>();
    }
    void Update()
    {
        Vector3 lerpedRotation = Vector3.Lerp(new Vector3(Input.acceleration.x * rotationAngleForce, 0, Input.acceleration.y * rotationAngleForce), cameraRotationCenter.rotation.eulerAngles, 0.5f);
        if(arrowInput)
            cameraRotationCenter.rotation = Quaternion.Euler(new Vector3(Input.GetAxis("Vertical") * rotationAngleForce, 0, Input.GetAxis("Horizontal") * rotationAngleForce));
        else
        {
            cameraRotationCenter.rotation = Quaternion.Euler(lerpedRotation);
        }
    }
}
