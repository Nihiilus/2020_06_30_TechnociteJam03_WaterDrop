using UnityEngine;

public abstract class FastProto_Block : MonoBehaviour
{
	public string _name;

	public void ToggleActive()
	{
		this.enabled = !this.enabled;
	}
}
