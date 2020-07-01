using UnityEngine;
using UnityEditor;

public class FastProto_Translate : FastProto_Transform
{
	public Vector3 _direction;

	void Update()
	{
		transform.Translate(_direction * GetInput() * _speed * Time.deltaTime, _space);
	}

	private void OnDrawGizmos()
	{
		Vector3 spaceAwareDirection = ReturnSpaceAwareVector(_direction,true);

		Handles.color = Color.magenta;

		Handles.DrawLine(transform.position, transform.position + spaceAwareDirection);
		Handles.ConeHandleCap(0, transform.position + spaceAwareDirection, Quaternion.LookRotation(spaceAwareDirection), 0.2f, EventType.Repaint);
	}
}
