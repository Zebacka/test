using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Timer : MonoBehaviour {
	public float StartTime;
	public string CurrentTime;
	
	public Rect timerRect;
	
	public Text text123;
	public Object object1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartTime += Time.deltaTime;
		CurrentTime = string.Format ("{0:0.00}", StartTime);

		text123 = GetComponent<Text>();
		text123.text = CurrentTime;
	}
}
