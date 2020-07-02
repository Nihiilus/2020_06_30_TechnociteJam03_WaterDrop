
using UnityEngine;

public class WaterFier : MonoBehaviour
{
    public float _bounceSpeed;
    public float _fallForce;
    public float _stiffness;

    private MeshFilter m_meshFilter;
    private Mesh m_mesh;

    WaterVertex[] m_waterVertices;
    Vector3[] m_currentMeshVertices;

    private void Start()
    {
        m_meshFilter = GetComponent<MeshFilter>();
        m_mesh = m_meshFilter.mesh;

        GetVertices();
    }

    private void GetVertices()
    {
        m_waterVertices = new WaterVertex[m_mesh.vertices.Length];
        m_currentMeshVertices = new Vector3[m_mesh.vertices.Length];
        for (int i = 0; i < m_mesh.vertices.Length; i++)
        {
            m_waterVertices[i] = new WaterVertex(i, m_mesh.vertices[i], m_mesh.vertices[i], Vector3.zero);
            m_currentMeshVertices[i] = m_mesh.vertices[i];
        }
    }

    private void Update()
    {
        UpdateVertices();
    }

    private void UpdateVertices()
    {
        for (int i = 0; i < m_waterVertices.Length; i++)
        {
            m_waterVertices[i].UpdateVelocity(_bounceSpeed);
            m_waterVertices[i].Settle(_stiffness);

            m_waterVertices[i].currentVertexPosition += m_waterVertices[i].currentVelocity * Time.deltaTime;
            m_currentMeshVertices[i] = m_waterVertices[i].currentVertexPosition;
        }

        m_mesh.vertices = m_currentMeshVertices;
        m_mesh.RecalculateBounds();
        m_mesh.RecalculateNormals();
        m_mesh.RecalculateTangents();
    }

    public void OnCollisionEnter(Collision other)
    {
        ContactPoint[] collisionPoints = other.contacts;
        for (int i = 0; i < collisionPoints.Length; i++)
        {
            Vector3 inputPoint = collisionPoints[i].point + (collisionPoints[i].point * .1f);
            ApplyPressureToPoint(inputPoint, _fallForce);
        }
    }

    public void ApplyPressureToPoint(Vector3 _point, float _pressure)
    {
        for (int i = 0; i<m_waterVertices.Length;i++)
        {
            m_waterVertices[i].ApplyPressureToVertex(transform, _point, _pressure);
        }
    }
}
