using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailByRayCast : MonoBehaviour
{

    public Transform m_raycasterStart;
    public Transform m_raycasterEnd;
    public LayerMask m_mask = 1;
    public Transform m_tail;
    public Transform m_waterCenter;
    public Transform m_tailDefaultPosition;
    public float m_lerpMultiplicator=1f;
    public Transform m_scaleReference;
  
    void Update()
    {

        Vector3 whereToGo;
        bool hasHit;
        Quaternion whatDirection;
        GetRaycastInformation( out hasHit, out whereToGo, out whatDirection );
        m_tail.position = Vector3.Lerp(m_tail.position, whereToGo, Time.deltaTime* m_lerpMultiplicator);
        //m_tail.rotation = Quaternion.Lerp(m_tail.rotation, whatDirection, Time.deltaTime* m_lerpMultiplicator);
    }

    private void GetRaycastInformation(out bool hasHit, out Vector3 whereToGo, out Quaternion whatDirection)
    {
        RaycastHit hit;
        Vector3 start, end, direction;
        start = m_raycasterStart.position;
        end = m_raycasterEnd.position;
        direction = end-start;


        hasHit = Physics.Raycast(start,direction, out hit, Vector3.Distance(start,end), m_mask);
        if (hasHit) {

            whereToGo = hit.point;
            whatDirection = m_tailDefaultPosition.rotation;
            Debug.DrawLine(m_raycasterStart.position, whereToGo, Color.green);
        }
        else
        {
            whereToGo = m_tailDefaultPosition.position;
            whatDirection = Quaternion.LookRotation(direction,Vector3.up);
            Debug.DrawLine(start,end, Color.red);
        }
    }
}
