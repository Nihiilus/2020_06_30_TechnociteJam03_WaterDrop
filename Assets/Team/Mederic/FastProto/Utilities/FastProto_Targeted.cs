using UnityEngine;
using System.Collections.Generic;

public abstract class FastProto_Targeted : FastProto_Block
{
	public List<FastProto_Target> _targets = new List<FastProto_Target>();
	public Sequence _sequence;

	public ushort _startIndex = 0;


	int targetIndex;
	int _targetIndex
	{
		get
		{
			return targetIndex;
		}
		set
		{
			targetIndex = value;
			_target = value>=0?_targets[value] : null;
		}
	}


	[HideInInspector]
	public FastProto_Target _target;

	protected virtual void Awake()
	{
		if(_targets != null && _targets.Count > 0)
		{
			switch(_sequence)
			{
				case Sequence.Manual:
				case Sequence.Ordered:
					_targetIndex = _startIndex % _targets.Count;
					break;

				case Sequence.Random:
				case Sequence.RandomNonRepeat:
					_targetIndex = Random.Range(0, _targets.Count);
					break;

				default:
					break;
			}
		}
		else
		{
			Debug.LogWarning("No target has been created so I do the dead", this.gameObject);
			Destroy(this);
		}

	}


	protected virtual void Update()
	{

		if(_target != null) _target.UpdatePosition();

		if(_targets != null && _targets.Count > 0 && _sequence != Sequence.Manual)
		{
			SwitchTarget();
		}
	}

	void SwitchTarget()
	{
		if(CheckTarget())
		{
			if(_target.OnTargetReached != null)
			{
				_target.OnTargetReached.Invoke();
			}

			switch(_sequence)
			{
				case Sequence.Ordered:
					_targetIndex = (_targetIndex + 1) % _targets.Count;
					break;
				case Sequence.Random:
					_targetIndex = Random.Range(0, _targets.Count);
					break;
				case Sequence.RandomNonRepeat:
					_targetIndex = (_targetIndex + Random.Range(1, _targets.Count)) % _targets.Count;
					break;
				default:
					break;
			}
		}
	}

	public void SetTarget(int index)
	{
		_targetIndex = Mathf.Min(index, _targets.Count - 1);
	}

	public void AddTarget(FastProto_Target newTarget)
	{
		for(int i = 0; i < _targets.Count; i++)
		{
			if(_targets[i]._target == newTarget._target)
			{
				return;
			}
		}

		_targets.Add(newTarget);
	}

	public void RemoveTarget(FastProto_Target targetToRemove)
	{

		for(int i = 0; i < _targets.Count; i++)
		{
			if(_targets[i]._target == targetToRemove._target)
			{
				_targets.RemoveAt(i);
				_targetIndex = _targets.Count==0 ? -1:(_targetIndex % _targets.Count);
				break;
			}
		}

	}




	protected abstract bool CheckTarget();
}
