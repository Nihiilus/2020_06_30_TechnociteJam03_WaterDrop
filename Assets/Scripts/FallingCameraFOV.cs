using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FallingCameraFOV : MonoBehaviour
{
    [SerializeField]
    Rigidbody rigidBodyFalling;
    Camera cam;

    [SerializeField]
    float effectStartingVelocity = 2;
    [SerializeField]
    float minFov = 5;
    float initialFov;
    [SerializeField]
    float duration = 2;
    [SerializeField]
    float backupDuration = 1;
    [SerializeField]
    [Header("Currently not working")]
    AnimationCurve animationCurve;

    float startingAnimationFov;


    float currentLerpTime = 0;
    bool isRecovering;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        initialFov = cam.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        if(rigidBodyFalling.velocity.y < -effectStartingVelocity)
        {
            if (isRecovering)
            {
                isRecovering = false;
                currentLerpTime = 0;
                startingAnimationFov = cam.fieldOfView;
            }
            
            if(cam.fieldOfView > minFov)
            {
                currentLerpTime += Time.deltaTime;
                float perc = currentLerpTime / duration;
                cam.fieldOfView = Mathf.Lerp(startingAnimationFov, minFov, perc);                
            }
            
        }
        else
        {
            if (!isRecovering)
            {
                isRecovering = true;
                currentLerpTime = 0;
                startingAnimationFov = cam.fieldOfView;
            }          
            if (cam.fieldOfView < initialFov)
            {
                currentLerpTime += Time.deltaTime;
                float perc = currentLerpTime / backupDuration;
                cam.fieldOfView = Mathf.Lerp(startingAnimationFov, initialFov, perc);
            }
        }
    }
}
