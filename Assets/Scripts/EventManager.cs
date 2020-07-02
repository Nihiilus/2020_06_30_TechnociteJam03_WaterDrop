using System;
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

    public class ChangingHPEventArgs : EventArgs
    {
        public float HPchange;
    }
    public event EventHandler<ChangingHPEventArgs> OnChangingHP;
    public void ChangingHP(ChangingHPEventArgs e) => OnChangingHP?.Invoke(this, e);
}