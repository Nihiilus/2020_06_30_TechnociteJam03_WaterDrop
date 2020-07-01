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

	private void OnDrawGizmos()
	{
		_spaceAwareDirection = ReturnSpaceAwareVector(_direction, true);

		Handles.color = Color.magenta;

		Handles.DrawLine(transform.position, transform.position + _spaceAwareDirection);
		Handles.ConeHandleCap(0, transform.position + _spaceAwareDirection, Quaternion.LookRotation(_spaceAwareDirection), 0.2f, EventType.Repaint);
	}
}
