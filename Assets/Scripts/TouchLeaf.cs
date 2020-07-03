
using UnityEngine;

public class TouchLeaf : MonoBehaviour
{
    WaterDropData drop;

    private void OnCollisionEnter(Collision collision)
    {
        drop = collision.gameObject.GetComponent<WaterDropData>();
        if (drop != null)
        {
            EventManager.instance.Touchleaves();
        }
    }
}
