using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float Force = 0.2f;
    public float Rotation = 1f;
    private Rigidbody _rigidBody = null;
    private Vector3 _movement;
    private Quaternion _rotation;

	void Start ()
    {
        _rigidBody = this.GetComponent<Rigidbody>();
	}

    void Update()
    {
        if(Input.GetKey(KeyCode.Z))
        {
            Debug.Log(@"update : Z");
            _movement = transform.forward * Force;   
        }

        if(Input.GetKey(KeyCode.S))
        {
            Debug.Log(@"update : S");
            _movement = transform.forward * -Force;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log(@"update : Q");
            _rotation = Quaternion.Euler(0f, -Rotation, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log(@"update : D");
            _rotation = Quaternion.Euler(0f, Rotation, 0f);
        }
    }
	
	void FixedUpdate ()
    {
        if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.S))
        {
            Debug.Log(@"FixedUpdate : Z ou S");
            this._rigidBody.MovePosition(_rigidBody.position + _movement);
        }

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.D))
        {
            Debug.Log(@"FixedUpdate : Q ou D");
            this._rigidBody.MoveRotation(_rigidBody.rotation * _rotation);
        }
	}
}
