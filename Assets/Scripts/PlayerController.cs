using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float Force = 10;
    private Rigidbody _rigidBody = null;
    private Vector3 _movement;

	void Start ()
    {
        this._rigidBody = this.GetComponent<Rigidbody>();
	}

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log(@"update : UpArrow");
            _movement = transform.forward * Force;   
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log(@"update : DownArrow");
            _movement = transform.forward * -Force;
        }
    }
	
	void FixedUpdate ()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log(@"FixedUpdate : Arrow");
            this._rigidBody.MovePosition(_rigidBody.position + _movement);
        }
	}
}
