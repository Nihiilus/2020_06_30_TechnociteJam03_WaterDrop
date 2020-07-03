
using UnityEngine;

public class EndManager : SceneSwitcher
{
    WaterDropData drop;
    private void OnCollisionEnter(Collision collision)
    {
        drop = collision.gameObject.GetComponent<WaterDropData>();
        if (drop != null)
        {
            Invoke("WinGame", 0.1f);
        }
    }

    void WinGame()
    {
        if (drop.health > 0)
            EventManager.instance.WinGame();
    }
}
