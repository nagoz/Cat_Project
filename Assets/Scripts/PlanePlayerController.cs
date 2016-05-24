using UnityEngine;
using System.Collections;

public class PlanePlayerController : MonoBehaviour 
{
    public PlayerController Me;

	// Use this for initialization
	void Start (){
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(@"enter collider : " + other.gameObject.name + @" - " + Me.name);

        if (other.gameObject.layer != 8 && !other.name.EndsWith("Local"))
            other.gameObject.layer = 10;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(@"exit collider : " + other.gameObject.name + @" - " + Me.name);

        if (other.gameObject.layer != 8 && !other.name.EndsWith("Local"))
            other.gameObject.layer = 0;
    }
}
