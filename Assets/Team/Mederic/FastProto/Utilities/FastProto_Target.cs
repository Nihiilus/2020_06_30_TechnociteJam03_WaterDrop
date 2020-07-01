using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class FastProto_Target
{
	public Transform _target;

	public Vector3 _offset;
	public Space _space;

	public UnityEvent OnTargetReached;

	public Vector3 _position
	{
		get;
		private set;
	}

	
	public void UpdatePosition()
	{
		if(_target )
		{
			_position = _target.position+ (_space == Space.Self ? _target.TransformDirection(_offset) : _offset);
		}
		else
		{
			_position = _offset;
		}
	}


	public FastProto_Target(Transform target,Vector3 offset, Space space = Space.World )
	{
		_target = target;
		_offset = offset;
		_space = space;
	}

}
