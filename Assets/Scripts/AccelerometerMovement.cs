using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AccelerometerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Input.acceleration.x * speed, 0, Input.acceleration.y * speed);
        Debug.Log(Input.acceleration);
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), Input.acceleration.ToString()))
        {
            print("You clicked the button!");
        }
    }
}