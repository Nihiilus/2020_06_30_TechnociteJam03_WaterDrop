
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

    [SerializeField]
    float m_minDistanceOfTail = 0.5f;

    internal void SetVertical(float inputVertical)
    {
        m_distanceVertical = Mathf.Clamp(inputVertical, -1, 1);
    }

    internal void SetHorizontal(float inputHorizontal)
    {
        m_distanceHorizontal = Mathf.Clamp(inputHorizontal, -1, 1); 
    }

    [SerializeField]
    float m_clampHorizontal = 0.5f;
    [SerializeField]
    float m_clampVertical = 0.5f;


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
        Vector3 worldPosition = _root.TransformDirection(Vector3.forward * -m_minDistanceOfTail + new Vector3(m_distanceHorizontal * m_clampHorizontal, 0, m_distanceVertical * m_clampVertical));

        _tail.position = worldPosition;
    }

    public static void Bonjour()
    {
        Debug.Log("bonjour");
    }
}

