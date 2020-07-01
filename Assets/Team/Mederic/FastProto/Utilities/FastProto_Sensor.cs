using UnityEngine;
using UnityEngine.Events;

public class FastProto_Sensor : FastProto_Block
{
	public LayerMask _layer;

	protected bool CheckLayer(int layer)
	{
		return _layer == (_layer | (1 << layer));
	}
}
