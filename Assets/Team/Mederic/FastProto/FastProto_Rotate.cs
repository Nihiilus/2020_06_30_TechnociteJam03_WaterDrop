using UnityEngine;
using UnityEditor;

public class FastProto_Rotate : FastProto_Transform
{
	public Vector3 _rotationAxis;

	private void Update()
	{
		transform.Rotate(_rotationAxis, _speed * GetInput() * Time.deltaTime, _space);
	}



}
