using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class ShotBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
        Destroy(this, 1);
    }
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * 1000f;
	
	}
}
