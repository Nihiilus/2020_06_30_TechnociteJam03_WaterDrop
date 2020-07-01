using UnityEngine;
using UnityEngine.Events;

public class FastProto_Raycast : FastProto_Sensor
{

	public float _distance;

	RaycastHit _raycastHit;

	public TargetEvent OnCastHit;
	public UnityEvent OnCastMiss;

	public void Cast()
	{
		if(Physics.Raycast(transform.position, transform.forward, out _raycastHit, _distance, _layer))
		{
			OnCastHit.Invoke(new FastProto_Target(_raycastHit.transform, _raycastHit.transform.InverseTransformPoint(_raycastHit.point),Space.Self));
		}
		else
		{
			OnCastMiss.Invoke();
		}
	}





}
