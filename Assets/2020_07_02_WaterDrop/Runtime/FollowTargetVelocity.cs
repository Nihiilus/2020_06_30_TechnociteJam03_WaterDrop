using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetVelocity : MonoBehaviour
{
    public Rigidbody m_target;
    public Transform m_toAffect;
    public bool m_useLerp;
    public float m_lerpPositionMultiplicator = 5;
    public float m_lerpRotationMultiplicator = 5;
    void Update()
    {
        m_toAffect.position =Vector3.Lerp(m_toAffect.position ,m_target.position, !m_useLerp?1f:Time.deltaTime*m_lerpPositionMultiplicator);
        Vector3 direction = m_target.velocity;
        direction.y = 0;
       
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up) ;
        m_toAffect.rotation =
            Quaternion.Lerp(m_toAffect.rotation,
            rotation,
            !m_useLerp ? 1f :
            Time.deltaTime * m_lerpPositionMultiplicator); 


    }
}
