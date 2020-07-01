
using UnityEngine;

public class FastProto_MoveTowardAnimator : FastProto_ForceToward
{
    public Animator _animator;

    
    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }
    public void SetRunAnimation(bool IsRunning = true)
    {
        _animator.SetBool("IsRunning", IsRunning);
    }

    //public void SetIdleAnimation()
    //{
    //    _animator.SetBool("IsRunning", false);
    //}
}
