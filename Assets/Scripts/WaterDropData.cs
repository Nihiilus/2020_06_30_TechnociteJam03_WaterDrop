using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class WaterDropData : MonoBehaviour
{
    [SerializeField] float maxHealth = 10;
    [SerializeField] float health;
    [SerializeField] [Range(0f, 1f)] float minimumSize;

    float initialScale;

    private void Start()
    {
        initialScale = transform.localScale.x;
        health = maxHealth;
        EventManager.instance.OnLosingHP += OnLosingHpEventHandler;
    }

    private void OnLosingHpEventHandler(object sender, EventManager.LosingHPEventArgs e)
    {
        health -= e.HPlost;
        if(health < 0)
        {
            EventManager.instance.LosingLastHP();
        }
        float newScale = minimumSize + (health / maxHealth * (initialScale - minimumSize));
        transform.localScale = new Vector3(newScale, newScale, newScale);
    }
}
