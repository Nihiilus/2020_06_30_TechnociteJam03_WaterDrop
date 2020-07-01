using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AccelerometerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float force;

    Vector2 acceleration;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        acceleration = Input.acceleration;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(acceleration.x * force * Time.fixedDeltaTime, 0, acceleration.y * force * Time.fixedDeltaTime);
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 150, 100), Input.acceleration.ToString());
    }
}