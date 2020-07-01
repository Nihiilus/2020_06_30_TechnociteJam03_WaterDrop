using UnityEngine;
using UnityEngine.Events;

public class FastProto_Input : FastProto_Block
{
	public KeyCode _input;

	public UnityEvent OnKeyDown;
	public UnityEvent OnKeyHold;
	public UnityEvent OnKeyUp;

	private void Update()
	{

		if (Input.GetKeyDown(_input))
		{
			OnKeyDown.Invoke();
		}

		if(Input.GetKey(_input))
		{
			OnKeyHold.Invoke();
		}

		if(Input.GetKeyUp(_input))
		{
			OnKeyUp.Invoke();
		}
	}
}
