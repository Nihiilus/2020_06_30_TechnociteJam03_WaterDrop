using UnityEngine;

public abstract class FastProto_Movement : FastProto_Block
{
	public InputAxis _inputAxis;
	protected float _input;
	public Space _space;

	protected float GetInput()
	{
		_input = Input.GetAxis(_inputAxis.ToString());
		return _input;
	}

	protected Vector3 ReturnSpaceAwareVector(Vector3 vector , bool normalize = false)
	{
		Vector3 vectorToReturn = _space == Space.Self ? transform.TransformDirection(vector) : vector;
		vectorToReturn = normalize ? vectorToReturn.normalized : vectorToReturn;

		return vectorToReturn;
	}
}
