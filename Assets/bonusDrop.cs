using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class bonusDrop : MonoBehaviour
{
    [SerializeField] float healthGained;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<WaterDropData>() != null)
        {
            EventManager.instance.ChangingHP(new EventManager.ChangingHPEventArgs() { HPchange = healthGained });
            Destroy(gameObject);
        }
    }
}
