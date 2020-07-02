using UnityEngine;
using UnityEditor;

public class FastProto_AddTorque : FastProto_Rigidbody
{
	public Vector3 _rotationAxis;
	Vector3 _spaceAwareRotationAxis;

	private void Update()
	{
		_spaceAwareRotationAxis = ReturnSpaceAwareVector(_rotationAxis,true);
		GetInput();
	}

	private void FixedUpdate()
	{
		_rigidbody.AddTorque(_spaceAwareRotationAxis * _input * _force * Time.fixedDeltaTime);
	}

}
