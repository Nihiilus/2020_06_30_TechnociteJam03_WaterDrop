
using System;
using UnityEngine;

public class TailInterface : MonoBehaviour
{
    [SerializeField]
    Transform _root;
    [SerializeField]
    Transform _tail;

    [Range(-1, 1)]
    [SerializeField]
    float m_distanceHorizontal;
    [Range(-1, 1)]
    [SerializeField]
    float m_distanceVertical;
    [Range(-1, 1)]
    [SerializeField]
    float m_distanceHeight;
    [Range(-1, 1)]
    [SerializeField]
    float m_tailRotation;

    [SerializeField]
    float m_minDistanceOfTail = 0.5f;
    [SerializeField]
    float m_rotationAngle = 45f;

    public void SetVertical(float inputVertical)
    {
        m_distanceVertical = Mathf.Clamp(inputVertical, -1, 1);
    }

    public void SetHorizontal(float inputHorizontal)
    {
        m_distanceHorizontal = Mathf.Clamp(inputHorizontal, -1, 1);
    }
    public void SetHeight(float inputHorizontal)
    {
        m_distanceHeight = Mathf.Clamp(inputHorizontal, m_clampHeightMin, m_clampHeightMax);
    }

    [SerializeField]
    float m_clampHorizontal = 0.5f;
    [SerializeField]
    float m_clampVertical = 0.5f;
    [SerializeField]
    float m_clampHeightMin = 0;
    [SerializeField]
    float m_clampHeightMax = 0.5f;
    [SerializeField]
    Vector3 m_rotationAdjustement= new Vector3(90,0,0);

    private void Update()
    {
        UpdateTailState();
    }

    private void OnValidate()
    {
        UpdateTailState();
    }

    private void UpdateTailState()
    {
        float height = Mathf.Lerp(m_clampHeightMin, m_clampHeightMax, m_distanceHeight);
        Vector3 worldPosition = ComputeWorldPosition(height);
        _tail.position = worldPosition;
        _tail.rotation = ComputeWorldRotation();
    }

    private Quaternion ComputeWorldRotation()
    {
       return (Quaternion.Euler(0, m_rotationAngle * m_tailRotation, 0) * _root.rotation) *
            Quaternion.Euler(m_rotationAdjustement);
    }

    private Vector3 ComputeWorldPosition(float height)
    {
        return _root.TransformPoint(Vector3.forward * -m_minDistanceOfTail + new Vector3(
            m_distanceHorizontal * m_clampHorizontal,
            height,
            m_distanceVertical * m_clampVertical));
    }

    public void SetRotation(float value) { 
        m_tailRotation=value;
    }

    public void ResetToDefault()
    {
        m_distanceHorizontal = m_distanceVertical = m_distanceHeight = m_tailRotation = 0;

    }
}

