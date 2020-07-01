using UnityEngine;

public class FastProto_TorqueToward : FastProto_RigidBodyTargeted
{

	public Vector3 _localLookVector = Vector3.forward;
	Vector3 _worldLookVector;

	Vector3 _rotationAxis;


	protected override void Update()
	{
		base.Update();

		_worldLookVector = transform.TransformDirection(_localLookVector).normalized;
		_rotationAxis = Vector3.Cross(_worldLookVector, _direction);
	}

	private void FixedUpdate()
	{
		_rigidbody.AddTorque( _rotationAxis  * _force * Time.fixedDeltaTime);
	}

	protected override bool CheckTarget()
	{
		return Vector3.Angle(_worldLookVector, _direction) <= _range;
	}
}
