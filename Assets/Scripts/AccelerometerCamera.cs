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

    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    void Update()
    {
        //cameraRotationCenter.rotation = Quaternion.Euler(new Vector3(Input.acceleration.x * rotationAngleForce, 0, Input.acceleration.y * rotationAngleForce));
    }
}
