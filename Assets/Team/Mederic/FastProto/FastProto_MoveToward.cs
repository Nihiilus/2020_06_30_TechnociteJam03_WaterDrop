using UnityEngine;

public class FastProto_MoveToward : FastProto_TransformTargeted
{

	protected override void Update()
	{
		base.Update();

		transform.position = Vector3.MoveTowards(transform.position, _target._position, _speed * Time.deltaTime);
	}

	protected override bool CheckTarget()
	{
		return (transform.position == _target._position) ;
	}

}
