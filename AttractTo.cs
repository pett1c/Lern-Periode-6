using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractTo : MonoBehaviour
{
    Rigidbody _rigidbody;
    public Transform _attractedTo;
    public float _strengthOfAttraction, _maxMagnitude;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( _attractedTo != null )
        {
            Vector3 direction = _attractedTo.position - transform.position;
            _rigidbody.AddForce (_strengthOfAttraction * direction);

            if (_rigidbody.velocity.magnitude > _maxMagnitude )
            {
                _rigidbody.velocity = _rigidbody.velocity.normalized * _maxMagnitude;
            }
        }

        
    }
}
