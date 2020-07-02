using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AccelerometerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float force;
    [SerializeField] bool keyInputCheat;
    [SerializeField] bool debugs;

    Vector2 acceleration;

    Vector2 keyInput;
    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        acceleration = Input.acceleration;
        keyInput.x = Input.GetAxis("Horizontal");
        keyInput.y = Input.GetAxis("Vertical");
        if(keyInputCheat)
            movement = new Vector3(keyInput.x, 0, keyInput.y) * force;
        else
            movement = new Vector3(acceleration.x, 0, acceleration.y) * force;

    }

    // Update is called once per frame
    void FixedUpdate()
    {          
        rb.AddForce(movement * Time.fixedDeltaTime);      
    }

    private void OnGUI()
    {
        if (debugs)
        {
            GUI.Box(new Rect(10, 10, 150, 30), movement.ToString());
            GUI.Box(new Rect(10, 50, 150, 30), keyInput.ToString());
            GUI.Box(new Rect(10, 90, 150, 30), acceleration.ToString());
        }       
    }
}