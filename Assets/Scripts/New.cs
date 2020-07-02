using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class New : MonoBehaviour
{
    public string MapToCharge;
    /*nom de lélement à charger*/

    public void StartGame()
    {
        SceneManager.LoadScene(MapToCharge);
        /*Charge l'élément ce trouvent dans le fichier MapToCharge*/
    }
}
