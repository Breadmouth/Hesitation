using UnityEngine;
using System.Collections;

public class SpriteScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float time = 20 * Time.deltaTime;
		transform.Rotate (new Vector3 (0, 0, 1), time);
	}
}
