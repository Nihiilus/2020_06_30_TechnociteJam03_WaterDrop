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


    


    public event EventHandler OnCatchBubble;
    public void CatchBubble() => OnCatchBubble?.Invoke(this, EventArgs.Empty);


    public event EventHandler OnWinGame;
    public void WinGame() => OnWinGame?.Invoke(this, EventArgs.Empty);


    public event EventHandler OnDeath;
    public void Death() => OnDeath?.Invoke(this, EventArgs.Empty);

    public event EventHandler OnTouchLeaves;
    public void Touchleaves() => OnTouchLeaves?.Invoke(this, EventArgs.Empty);



    public class ChangingHPEventArgs : EventArgs
    {
        public float HPchange;
    }
    public event EventHandler<ChangingHPEventArgs> OnChangingHP;
    public void ChangingHP(ChangingHPEventArgs e) => OnChangingHP?.Invoke(this, e);
}