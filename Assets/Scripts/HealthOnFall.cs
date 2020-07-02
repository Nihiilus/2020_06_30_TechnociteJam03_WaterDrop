using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HealthOnFall : MonoBehaviour
{
    [SerializeField] float minDistanceToLoseHealth = 1;
    [SerializeField] float minHealthLost = 1;
    [SerializeField] float maxDistanceToLoseHealth = 10;
    [SerializeField] float maxHealthLost = 10;

    Rigidbody rb;
    bool isFalling;
    float startHeight;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(rb.velocity.y < -1)
        {
            if (!isFalling)
            {
                startHeight = transform.position.y;
                isFalling = true;
            }

        }
        else
        {
            if (isFalling && startHeight - transform.position.y > minDistanceToLoseHealth)
            {
                // The object finished its fall and will lose health
                float fallDistanceNormalized = Mathf.Min((startHeight - transform.position.y) / (maxDistanceToLoseHealth - minDistanceToLoseHealth), 1);
                float healthLost = ((maxHealthLost - minHealthLost) * fallDistanceNormalized) + minHealthLost;


                EventManager.instance.LosingHP(new EventManager.LosingHPEventArgs() { HPlost = healthLost });               
            }
            isFalling = false;
        }
    }
}
