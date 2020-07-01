using UnityEngine;
using UnityEditor;

public class FastProto_Rotate : FastProto_Transform
{
	public Vector3 _rotationAxis;

	private void Update()
	{
		transform.Rotate(_rotationAxis, _speed * GetInput() * Time.deltaTime, _space);
	}

	
	private void OnDrawGizmos()
	{
		float angle = 45;
		Vector3 spaceAwareRotationAxis = ReturnSpaceAwareVector(_rotationAxis,true) ;
		Vector3 startArcVector = Vector3.Cross((transform.right == spaceAwareRotationAxis ? transform.forward : transform.right), spaceAwareRotationAxis);

		Handles.color = new Color(0,1,0,0.25f);
		Handles.DrawSolidArc(transform.position, spaceAwareRotationAxis, startArcVector, angle, 1);

		Handles.color = new Color(1,0,0,0.25f);
		Handles.DrawSolidArc(transform.position, spaceAwareRotationAxis, startArcVector, -angle, 1);
	}


}
