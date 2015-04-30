using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {
	float time;
	public static string current;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("FIRST");
		if (other.gameObject.tag == "Player"){
			GameObject thePlayer = GameObject.Find("Text_timer");
			Timer timer = thePlayer.GetComponent<Timer>();
			current = timer.CurrentTime;
			print (current);

			//Application.LoadLevel("2");
				
	}
}
}