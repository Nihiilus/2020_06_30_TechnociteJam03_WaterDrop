using UnityEngine;

public class FastProto_Counter : FastProto_Block
{
	[SerializeField]
	int currentValue;
	public int _currentValue
	{
		get
		{
			return currentValue;
		}
		set
		{
			currentValue = value;
			CheckValues();
		}
	}

	public FastProto_TargetValue[] _targets;

	public void Increase(int amount)
	{
		_currentValue += amount;
	}

	public void Decrease(int amount)
	{
		_currentValue -= amount;
	}

	public void SetValue(int value)
	{
		_currentValue = value;
	}


	void CheckValues()
	{
		foreach(FastProto_TargetValue targetValue in _targets)
		{
			if(_currentValue == targetValue._value)
			{
				targetValue.OnValueReached.Invoke();
			}
		}
	}
}
