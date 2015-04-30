using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("FIRST");
		if (other.gameObject.tag == "Player")
			Debug.Log("Hit");
			Application.LoadLevel("2");
	}
}
