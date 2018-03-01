using UnityEngine;
using System.Collections;

public class gameovercheck : MonoBehaviour {
	float distanceToBlockThatLosesGame = 50.000000f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject go0 = GameObject.Find ("FPSController");
		GameObject go1 = GameObject.Find ("Cube");
		GameObject go2 = GameObject.Find ("Cube2");
		GameObject go3 = GameObject.Find ("Cube3");
		GameObject go4 = GameObject.Find ("Cube4");
		GameObject go5 = GameObject.Find ("Cube5");
		GameObject go6 = GameObject.Find ("Cube6");
		GameObject go7 = GameObject.Find ("Cube7");
		GameObject go8 = GameObject.Find ("Cube8");
		GameObject go9 = GameObject.Find ("Cube9");
		GameObject go10 = GameObject.Find ("Cube10");

		float dist1 = Vector3.Distance (go0.transform.position, go1.transform.position);
		float dist2 = Vector3.Distance (go0.transform.position, go2.transform.position);
		float dist3 = Vector3.Distance (go0.transform.position, go3.transform.position);
		float dist4 = Vector3.Distance (go0.transform.position, go4.transform.position);
		float dist5 = Vector3.Distance (go0.transform.position, go5.transform.position);
		float dist6 = Vector3.Distance (go0.transform.position, go5.transform.position);
		float dist7 = Vector3.Distance (go0.transform.position, go5.transform.position);
		float dist8 = Vector3.Distance (go0.transform.position, go5.transform.position);
		float dist9 = Vector3.Distance (go0.transform.position, go5.transform.position);
		float dist10 = Vector3.Distance (go0.transform.position, go5.transform.position);

		if (dist1 < distanceToBlockThatLosesGame || dist2 < distanceToBlockThatLosesGame || dist3 < distanceToBlockThatLosesGame || dist4 < distanceToBlockThatLosesGame || dist5 < distanceToBlockThatLosesGame || dist6 < distanceToBlockThatLosesGame || dist6 < distanceToBlockThatLosesGame || dist7 < distanceToBlockThatLosesGame || dist8 < distanceToBlockThatLosesGame || dist9 < distanceToBlockThatLosesGame || dist10 < distanceToBlockThatLosesGame) {
			UnityEditor.EditorApplication.isPlaying = false;
		} 
	}
}
