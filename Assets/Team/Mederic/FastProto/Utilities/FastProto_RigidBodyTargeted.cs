using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class FastProto_RigidBodyTargeted : FastProto_Targeted
{
	protected Rigidbody _rigidbody;
	public float _force;
	public float _range;
	protected Vector3 _direction;

	protected override void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();

		base.Awake();
	}

	protected override void Update()
	{
		base.Update();

		_direction = (_target._position - transform.position).normalized;
	}

	public void SetForce(float force)
	{
		_force = force;
	}
}
