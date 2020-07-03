using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image loseMenu;
    [SerializeField] Image winMenu;
    void Start()
    {
        EventManager.instance.OnLosingLastHP += OnLosingLastHpHandler;
        EventManager.instance.OnWinGame += OnWinGame;
    }

    private void OnWinGame(object sender, EventArgs e)
    {
        Time.timeScale = 0;
        winMenu.gameObject.SetActive(true);
    }

    private void OnLosingLastHpHandler(object sender, EventArgs e)
    {
        Time.timeScale = 0;
        loseMenu.gameObject.SetActive(true);
    }
}
