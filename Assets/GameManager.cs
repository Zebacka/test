using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public float StartTime;
	public string CurrentTime;

	public Rect timerRect;

	public GUISkin skin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartTime += Time.deltaTime;
		CurrentTime = string.Format ("{0:0.0}", StartTime);


	}


	void OnGUI()
	{
		GUI.Label (timerRect, CurrentTime);

	}




}
