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


	private void OnDrawGizmos()
	{
		float angle = 45;
		_spaceAwareRotationAxis = ReturnSpaceAwareVector(_rotationAxis,true) ;
		Vector3 startArcVector = Vector3.Cross((transform.right == _spaceAwareRotationAxis ? transform.forward : transform.right), _spaceAwareRotationAxis);

		Handles.color = new Color(0, 1, 0, 0.25f);
		Handles.DrawSolidArc(transform.position, _spaceAwareRotationAxis, startArcVector, angle, 1);

		Handles.color = new Color(1, 0, 0, 0.25f);
		Handles.DrawSolidArc(transform.position, _spaceAwareRotationAxis, startArcVector, -angle, 1);
	}
}
