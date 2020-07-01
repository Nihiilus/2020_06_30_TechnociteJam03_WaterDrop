using UnityEngine;
using UnityEngine.Events;

public class FastProto_FPSRayShoot : FastProto_Sensor
{
    public float _distance;

    RaycastHit _raycastHit;
    public int _damage;
    public int _force;

    public GameObject _hitFXPrefabWall;
    public GameObject _hitFXPrefabZombie;

    public void Shoot()
    {
        
        if (Physics.Raycast(transform.position, transform.forward, out _raycastHit, _distance, _layer))
        {
            FastProto_Counter counter = _raycastHit.collider.gameObject.GetComponent<FastProto_Counter>();
            Rigidbody rigidbody = _raycastHit.collider.gameObject.GetComponent<Rigidbody>();

            if(rigidbody)
            {
                rigidbody.AddForceAtPosition(transform.forward * _force, _raycastHit.point, ForceMode.VelocityChange);
            }
            if (counter)
            {
                Instantiate(_hitFXPrefabZombie, _raycastHit.point, Quaternion.LookRotation(_raycastHit.normal));
                counter.Decrease(_damage);
            } 
            else
            {
                // Create impact effect
                Instantiate(_hitFXPrefabWall, _raycastHit.point, Quaternion.LookRotation(_raycastHit.normal));
            }
        }    
    }

    

}
