using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class FastProto_Rigidbody : FastProto_Movement
{
	protected Rigidbody _rigidbody;
	public float _force;


	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}


	public void SetForce(float force)
	{
		_force = force;
	}
}
