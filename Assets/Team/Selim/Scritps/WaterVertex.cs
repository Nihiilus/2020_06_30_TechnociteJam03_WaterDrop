
using UnityEngine;

public class WaterVertex
{
    public int verticesIndex;
    public Vector3 initialVertexPoint;
    public Vector3 currentVertexPosition;

    public Vector3 currentVelocity;

    public WaterVertex(int _verticesIndex, Vector3 _initialVertexPosition, Vector3 _currentVertexPosition, Vector3 _currentVelocity)
    {
        verticesIndex = _verticesIndex;
        initialVertexPoint = _initialVertexPosition;
        currentVertexPosition = _currentVertexPosition;
        currentVelocity = _currentVelocity;
    }

    public Vector3 GetCurrentDisplacement()
    {
        return currentVertexPosition = initialVertexPoint;
    }

    public void UpdateVelocity(float bounceSpeed)
    {
        currentVelocity = currentVelocity - GetCurrentDisplacement() * bounceSpeed * Time.deltaTime;
    }

    public void Settle(float stiffness)
    {
        currentVelocity *= 1f - stiffness * Time.deltaTime;
    }

    public void ApplyPressureToVertex(Transform m_transform,Vector3 m_position, float m_pressure)
    {
        Vector3 m_distanceVerticesPoint = currentVertexPosition - m_transform.InverseTransformPoint(m_position);
        float m_adaptedPressure = m_pressure/(1f + m_distanceVerticesPoint.sqrMagnitude) ;
        float m_velocity = m_adaptedPressure * Time.deltaTime;
        currentVelocity += m_distanceVerticesPoint.normalized * m_velocity;
    }
}
