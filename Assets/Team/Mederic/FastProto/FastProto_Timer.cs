using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class FastProto_Timer : FastProto_Block
{
	public float _startDelay = 0;
	public float _delay = 1;
	public bool _repeat;

	WaitForSeconds _waitStartDelay;
	WaitForSeconds _waitDelay;

	public UnityEvent OnTimerReached;

	bool _isTimerRunning = false;

	private void Awake()
	{
		_waitStartDelay = new WaitForSeconds(_startDelay);
		_waitDelay = new WaitForSeconds(_delay);
	}

	private void OnEnable()
	{
		StartCoroutine(Timing());
	}

	private void OnDisable()
	{
		_isTimerRunning = false;
	}

	public void RestartTimer()
	{
		StopTimer();
		StartTimer();
	}

	public void StartTimer()
	{
		if(!_isTimerRunning)
		{
			StartCoroutine(Timing());
		}
	}

	public void StopTimer()
	{
		StopAllCoroutines();
		_isTimerRunning = false;
	}

	public void ChangeDelay(float newDelay)
	{
		_delay = newDelay;
		_waitDelay = new WaitForSeconds(_delay);
	}

	public void ChangeStartDelay(float newStartDelay)
	{
		_startDelay = newStartDelay;
		_waitStartDelay = new WaitForSeconds(_startDelay);
	}

	IEnumerator Timing()
	{
		_isTimerRunning = true;

		yield return _waitStartDelay;

		while(_repeat)
		{
			yield return _waitDelay;
			OnTimerReached.Invoke();
		}

		yield return _waitDelay;
		OnTimerReached.Invoke();

		_isTimerRunning = false;
	}
}
