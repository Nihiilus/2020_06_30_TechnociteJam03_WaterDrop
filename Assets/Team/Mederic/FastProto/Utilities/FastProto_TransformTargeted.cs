using UnityEngine;

public abstract class FastProto_TransformTargeted : FastProto_Targeted
{
	public float _speed = 1;

	public void SetSpeed(float speed)
	{
		_speed = speed;
	}
}
