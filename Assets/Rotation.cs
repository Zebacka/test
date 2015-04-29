using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
//	bool moveleft = false;
//	bool moveright = false;

	void Update () {
//		moveleft = false;
//		moveright = false;
//		if (Input.GetMouseButtonDown (0)) {
//			float x = Input.mousePosition.x;
//			if(x < Screen.width/2){
//				moveleft = true;
//				moveright = false;
//				
//			}
//			else{
//				moveleft = false;
//				moveright = true;
//				
//			}
//			
//		}

		if (Input.GetMouseButton(0)) {
			Debug.Log("Held");
			float x = Input.mousePosition.x;
				if(x < Screen.width/2){
				transform.Rotate(0,0,1);

			}
			else{
		
				transform.Rotate(0,0,-1);

			}


		}
	}
	
//	void FixedUpdate () {
//		if (moveright == true) {
//			transform.Rotate(0,0,1);
//
//		}
//		
//		if (moveleft == true) {		
//			transform.Rotate(0,0,1);
//
//		}
//		
//	}
}
