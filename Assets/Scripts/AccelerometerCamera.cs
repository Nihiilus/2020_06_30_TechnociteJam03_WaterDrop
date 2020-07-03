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
    [SerializeField] float lerpFactor = 1;

    Quaternion wantedRotation;

    private void Start()
    {        
        cam = GetComponent<Camera>();
    }
    void Update()
    {
        if(arrowInput)
            cameraRotationCenter.rotation = Quaternion.Euler(new Vector3(Input.GetAxis("Vertical") * rotationAngleForce, 0, Input.GetAxis("Horizontal") * rotationAngleForce));
        else
        {
            // lerp to smooth it but HOW?
            wantedRotation = Quaternion.Euler(new Vector3(Input.acceleration.x * rotationAngleForce, 0, Input.acceleration.y * rotationAngleForce));

            cameraRotationCenter.rotation = Quaternion.Lerp(cameraRotationCenter.rotation, wantedRotation, Time.deltaTime * lerpFactor);
        }
    }
}
