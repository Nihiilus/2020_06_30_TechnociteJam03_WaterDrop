using UnityEngine;

public abstract class FastProto_Transform : FastProto_Movement
{

	public float _speed = 1;

	public void SetSpeed(float speed)
	{
		_speed = speed;
	}
}
