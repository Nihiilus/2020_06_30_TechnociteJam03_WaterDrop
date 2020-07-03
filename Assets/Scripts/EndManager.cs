
using UnityEngine;

public class EndManager : SceneSwitcher
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<WaterDropData>() != null)
        {
            EventManager.instance.WinGame();
        }
    }
}
