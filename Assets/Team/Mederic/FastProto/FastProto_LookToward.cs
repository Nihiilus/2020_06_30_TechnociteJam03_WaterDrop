using UnityEngine;

public class FastProto_LookToward : FastProto_TransformTargeted
{
	Vector3 _targetDirection;

	public Vector3 _localLookVector = Vector3.forward;
	Vector3 _worldLookVector;

	Vector3 _rotationAxis;
	float _delta = 1;//prevent the CheckTarget to return true in the first step of the update
	float _rotationStep;

	protected override void Update()
	{
		base.Update();

		_worldLookVector = transform.TransformDirection(_localLookVector).normalized;
		_targetDirection = (_target._position - transform.position).normalized;


		if(Vector3.Dot(_worldLookVector, _targetDirection) == -1) 
		{
			_worldLookVector = (_worldLookVector+transform.right*0.01f);
		}


		_rotationAxis = Vector3.Cross(_targetDirection, _worldLookVector);

		_delta = Vector3.SignedAngle(_worldLookVector, _targetDirection, _rotationAxis);
		_rotationStep = Mathf.Min(Mathf.Abs(_delta), _speed * Time.deltaTime)* Mathf.Sign(_delta);


		transform.Rotate(_rotationAxis, _rotationStep, Space.World);
	}

	protected override bool CheckTarget()
	{
		return _delta == 0;
	}
}
