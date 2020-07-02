using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image loseMenu;
    void Start()
    {
        EventManager.instance.OnLosingLastHP += OnLosingLastHpHandler;
    }

    private void OnLosingLastHpHandler(object sender, EventArgs e)
    {
        Time.timeScale = 0;
        loseMenu.gameObject.SetActive(true);
    }
}
