using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region SINGLETON
    // SINGLETON 
    public static EventManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one EventManager in scene");
            return;
        }
        instance = this;
    }
    #endregion

    public event EventHandler OnLosingLastHP;
    public void LosingLastHP() => OnLosingLastHP?.Invoke(this, EventArgs.Empty);

    public class LosingHPEventArgs : EventArgs
    {
        public float HPlost;
    }
    public event EventHandler<LosingHPEventArgs> OnLosingHP;
    public void LosingHP(LosingHPEventArgs e) => OnLosingHP?.Invoke(this, e);
}