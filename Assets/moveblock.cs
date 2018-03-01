using UnityEngine;
using System.Collections;

public class moveblock : MonoBehaviour {
	bool rotate = false;
	bool zGoingUp = false;
	bool xGoingUp = false;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		//GameObject go1 = GameObject.Find ("Cube");
		//GameObject go2 = GameObject.Find ("FPSController");

	//	float dist = Vector3.Distance (go1.transform.position, go2.transform.position);

	//	if (dist < 10.0) {
	//		UnityEditor.EditorApplication.isPlaying = false;
	//	}

		transform.Translate (Vector3.forward * Time.deltaTime);

		//Z: 507-27		Forward +1		back -1
		//X: 14-480		right +1		left -1

		if (transform.position.z < 27.0) {
			zGoingUp = true;
		} else if (transform.position.z > 506.0) {
			zGoingUp = false;
		}

		if (transform.position.x < 14.0) {
			xGoingUp = true; 
		} else if (transform.position.x > 480.0) {
			xGoingUp = false;	
		}

		if (zGoingUp == false) {
			transform.Translate (Vector3.back * Time.deltaTime * 10);
		} else {
			transform.Translate (Vector3.forward * Time.deltaTime * 10);
		}

		if (xGoingUp == false) {
			transform.Translate (Vector3.left * Time.deltaTime * 10);
		} else {
			transform.Translate (Vector3.right * Time.deltaTime * 10);
		}



		if (rotate == true) {
			transform.Rotate (Vector3.right * Time.deltaTime*10);
			transform.Rotate (Vector3.up * Time.deltaTime*10, Space.World);
		}

		if (Input.GetKeyDown ("c"))
			rotate = true;
		if (Input.GetKeyDown ("z"))
			rotate = false;
		if (Input.GetKeyDown ("q")) {
			Application.Quit ();
			UnityEditor.EditorApplication.isPlaying = false;
		}

		//Vector3 dist = Vector3.Distance(go1.transform.position, go2.transform.position);
		//Debug.Log (string.Format ("Distance between {0} and {1} is: {2}", go1, go2, dist));
		//Debug.Log(string.Format("Distance is: {0}", dist));
	}


}
