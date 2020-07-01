using UnityEngine;

public class FastProto_ForceToward : FastProto_RigidBodyTargeted
{

	private void FixedUpdate()
	{
		_rigidbody.AddForce(_direction * _force * Time.fixedDeltaTime);
	}

	protected override bool CheckTarget()
	{
		return Vector3.Distance(transform.position, _target._position) <= _range;
	}

}
