using UnityEditor;
using UnityEngine;

public class FastProto_AddForce : FastProto_Rigidbody
{
	public Vector3 _direction;
	Vector3 _spaceAwareDirection;


	void Update()
	{
		_spaceAwareDirection = ReturnSpaceAwareVector(_direction,true) ;
		GetInput();
	}

	void FixedUpdate()
    {
		_rigidbody.AddForce(_spaceAwareDirection * _input * _force * Time.fixedDeltaTime);
    }
}
