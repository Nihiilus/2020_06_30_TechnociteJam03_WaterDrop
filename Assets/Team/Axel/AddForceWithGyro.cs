using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AddForceWithGyro : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    public bool testDir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Input.acceleration.x * speed, 0, -Input.acceleration.z * speed);
    }
}