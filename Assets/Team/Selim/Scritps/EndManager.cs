
using UnityEngine;

public class EndManager : SceneSwitcher
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ReloadScene();
            Debug.Log("it's working");
        }
    }
}
