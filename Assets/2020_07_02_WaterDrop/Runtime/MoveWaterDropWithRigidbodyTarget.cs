using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveWaterDropWithRigidbodyTarget : MonoBehaviour
{
    public Rigidbody m_targetRigidbody;
    public Transform m_targetToFollow;
    public Transform m_waterdropToMove;
    public TailInterface m_tailInterface;

    public float m_lerpMulticator=2f;
    public Quaternion m_wantedRotation=Quaternion.identity;
    public Quaternion m_currentRotation = Quaternion.identity;
    [Header("Debug")]
    public Vector3 m_targetVelocite;
    public Vector3 directionLocalOfTarget;
    public float m_trailHorizontalMulti = 1f;
    public float m_trailLenghtMulti = 1f;
    public float m_rotationAngle = 30;


    public bool m_onlyHorizontalMove=true;
    public float m_lerpMultiplicator=4;
    [Header("Debug")]
    public float moveHorizontal;
    public float moveSpeed;
    public void Update()
    {
        { // set and update position rotation
        m_targetVelocite = m_targetRigidbody.velocity;
            if (m_onlyHorizontalMove)
                m_targetVelocite.y = 0;

         m_wantedRotation = Quaternion.LookRotation(m_targetVelocite, Vector3.up);
         m_currentRotation = Quaternion.Lerp(m_currentRotation, m_wantedRotation, Time.deltaTime* m_lerpMultiplicator);
         m_waterdropToMove.position = Vector3.Lerp(m_waterdropToMove.position, m_targetToFollow.position, Time.deltaTime * 5);
         m_waterdropToMove.rotation = Quaternion.Lerp(m_waterdropToMove.rotation, m_currentRotation, Time.deltaTime * 5);

        }

        directionLocalOfTarget = m_currentRotation * Vector3.forward;




        moveHorizontal = Mathf.Clamp(directionLocalOfTarget.x * m_trailHorizontalMulti, -1f, 1f);
        m_tailInterface.SetHorizontal(moveHorizontal);
        m_tailInterface.SetRotation(moveHorizontal);

        moveSpeed = m_targetRigidbody.velocity.magnitude * m_trailLenghtMulti;
        m_tailInterface.SetVertical(- moveSpeed * m_trailLenghtMulti);
        m_tailInterface.SetHeight(- moveSpeed * m_trailLenghtMulti);

        if (m_useDebug) { 
            Debug.DrawLine(Vector3.zero, directionLocalOfTarget, Color.cyan);
            Debug.DrawLine(m_targetToFollow.position , m_targetToFollow.position + directionLocalOfTarget, Color.red);
        }
    }

    public bool m_useDebug;
}



//using JetBrains.Annotations;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MoveWaterDropWithRigidbodyTarget : MonoBehaviour
//{
//    public Rigidbody m_targetRigidbody;
//    public Transform m_targetToFollow;
//    public Transform m_waterdropToMove;
//    public TailInterface m_tailInterface;
//    public ObjectTrackedHistory m_tailHistory = new ObjectTrackedHistory();
//    [System.Serializable]
//    public class ObjectTrackedHistory
//    {
//        public float m_delay = 0.1f;
//        public int m_maxCount = 4;
//        public List<Vector3> m_previousPositions = new List<Vector3>();
//        public List<Vector3> m_previousDirections = new List<Vector3>();

//        public void Insert(Vector3 direction, Vector3 position)
//        {

//            m_previousPositions.Insert(0, position);
//            if (m_previousPositions.Count > m_maxCount)
//                m_previousPositions.RemoveAt(m_previousDirections.Count - 1);

//            m_previousDirections.Insert(0, direction);
//            if (m_previousDirections.Count > m_maxCount)
//                m_previousDirections.RemoveAt(m_previousDirections.Count - 1);
//        }

//        public Vector3 GetDirectionAverage()
//        {
//            Vector3 result = new Vector3();
//            for (int i = 0; i < m_previousDirections.Count; i++)
//            {
//                result += m_previousDirections[i];
//            }
//            result /= (float)m_previousDirections.Count;
//            return result;
//        }
//    }

//    [Header("Debug")]
//    public Vector3 m_velocite;
//    public Vector3 m_directionAverage;

//    public void Start()
//    {
//        InvokeRepeating("AddTailPoint", 0, m_tailHistory.m_delay);
//    }

//    public void AddTailPoint()
//    {
//        m_tailHistory.Insert(m_targetToFollow.position, m_targetToFollow.forward);
//    }
//    public void Update()
//    {
//        m_velocite = m_targetRigidbody.velocity;
//        m_waterdropToMove.position = m_targetToFollow.position;
//        m_waterdropToMove.rotation = Quaternion.LookRotation(m_velocite, Vector3.up);
//        m_directionAverage = m_tailHistory.GetDirectionAverage();
//        Debug.DrawLine(m_targetToFollow.position, m_targetToFollow.position + m_directionAverage, Color.red);


//    }
//}
