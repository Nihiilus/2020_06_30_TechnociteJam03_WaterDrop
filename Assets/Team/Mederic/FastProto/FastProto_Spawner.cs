using UnityEngine;

public class FastProto_Spawner : FastProto_Block
{
	
	public GameObject _prefab;

	public FastProto_Target _spawnTarget ;

	public Transform _parent;

	[Tooltip("Keep Infinity to prevent the game object from being destroyed by the spawner")]
	public float _despawnTime = Mathf.Infinity;

	[SerializeField]
	RotationType _rotationType = RotationType.Self;

	Vector3 _spawnPosition;
	Quaternion _spawnRotation;

	public void Spawn()
	{
		CheckForPrefab();

		_spawnTarget.UpdatePosition();
		_spawnPosition = _spawnTarget._position;

		switch(_rotationType)
		{
			case RotationType.Identity:
				_spawnRotation = Quaternion.identity;
				break;
			case RotationType.Target:
				_spawnRotation = _spawnTarget._target == null ? Quaternion.identity : _spawnTarget._target.rotation;
				break;
			case RotationType.Self:
				_spawnRotation = transform.rotation;
				break;
			default:
				break;
		}

		GameObject spawnedObject = Instantiate(_prefab, _spawnPosition, _spawnRotation,_parent) ;

		if(_despawnTime < Mathf.Infinity)
		{
			Destroy(spawnedObject, _despawnTime);
		}
	}

	public void ChangeDespawnTime(float newDespawnTime)
	{
		_despawnTime = newDespawnTime;
	}

	void CheckForPrefab()
	{
		if(_prefab == null)
		{
			Debug.LogWarning("No prefab has been selected so I'm gonna kill myself", this.gameObject);
			Destroy(this);
		}
	}

	public void ChangePrefab(FastProto_Target newPrefab)
	{
		if(newPrefab._target != null)
		{
			_prefab = newPrefab._target.gameObject;
		}
	}

	public void ChangeSpawnTarget(FastProto_Target newTarget)
	{
		_spawnTarget = newTarget;
	}



	private void Reset()
	{
		_spawnTarget = new FastProto_Target(transform, Vector3.zero);
	}

}
