using UnityEngine;

[RequireComponent(typeof(Collider))]
public class FastProto_Collision : FastProto_Sensor
{

	public bool _isTrigger;
	Collider _collider;

	public TargetEvent OnEnter;
	public TargetEvent OnStay;
	public TargetEvent OnExit;

	private void Awake()
	{
		_collider = GetComponent<Collider>();
		_collider.isTrigger = _isTrigger;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(CheckLayer(collision.gameObject.layer))
		{
			OnEnter.Invoke( new FastProto_Target(collision.transform, collision.transform.InverseTransformPoint(collision.GetContact(0).point), Space.Self) );
		}
	}
	private void OnCollisionStay(Collision collision)
	{
		if(CheckLayer(collision.gameObject.layer))
		{
			OnStay.Invoke(new FastProto_Target(collision.transform, collision.transform.InverseTransformPoint(collision.GetContact(0).point), Space.Self));
		}
	}
	private void OnCollisionExit(Collision collision)
	{
		if(CheckLayer(collision.gameObject.layer))
		{
			OnExit.Invoke(new FastProto_Target(collision.transform, collision.transform.InverseTransformPoint(collision.GetContact(0).point), Space.Self));
		}
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if(CheckLayer(other.gameObject.layer))
		{
			OnEnter.Invoke( new FastProto_Target(other.transform,Vector3.zero) );
		}
	}
	private void OnTriggerStay(Collider other)
	{
		if(CheckLayer(other.gameObject.layer))
		{
			OnStay.Invoke( new FastProto_Target(other.transform, Vector3.zero));
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if(CheckLayer(other.gameObject.layer))
		{
			OnExit.Invoke(new FastProto_Target(other.transform, Vector3.zero));
		}
	}


}
