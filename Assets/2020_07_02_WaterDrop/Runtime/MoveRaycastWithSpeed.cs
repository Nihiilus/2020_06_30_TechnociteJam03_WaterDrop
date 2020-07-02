using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRaycastWithSpeed : MonoBehaviour
{
    public Transform m_directionToMove;
    public Transform m_toAffect;
    public float m_multiplicator=1;
    public float m_minLenght=0.1f;
    public float m_maxLenght=0.4f;
    public Vector3 m_currentPosition;
    public Vector3 m_previousPosition;
    //public List<Vector3> m_recordedKey;
    //public int m_maxRecord=10;
    //private void Start()
    //{
    //    InvokeRepeating("RecordKey", 0, 0.1f);
    //}
    void Update()
    {
        m_currentPosition = m_directionToMove.position;
        Vector3 deltaMoved = m_currentPosition - m_previousPosition;
        m_toAffect.localPosition =
            m_directionToMove.forward *
            -Mathf.Clamp(deltaMoved.magnitude* m_multiplicator, m_minLenght, m_maxLenght);
        m_previousPosition = m_currentPosition;
    }
}
