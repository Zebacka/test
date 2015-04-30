using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	Ray ray;
	RaycastHit hit;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {

			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit))
			{
				print (hit.collider.name);
				Application.LoadLevel("start");

			}

		}
	}

	void OnMouseDown(){
		// this object was clicked - do something

	}   


}
