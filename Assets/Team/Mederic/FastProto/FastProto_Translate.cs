using UnityEngine;
using UnityEditor;

public class FastProto_Translate : FastProto_Transform
{
	public Vector3 _direction;

	void Update()
	{
		transform.Translate(_direction * GetInput() * _speed * Time.deltaTime, _space);
	}
}
