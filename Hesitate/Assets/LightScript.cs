using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	public Light lt;
	float angle;
	public float cos;

	// Use this for initialization
	void Start () {
		lt = GetComponent<Light> ();
		angle = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float time = 20 * Time.deltaTime;
		angle += time;
		transform.RotateAround (new Vector3 (0, 0, 0), new Vector3 (0, 0, 1), time);
		lt.intensity = -1 * Mathf.Sin (angle * Mathf.PI / 180);
		cos = Mathf.Abs(Mathf.Sin (angle * Mathf.PI / 180 ));
		lt.color = new Color(1, cos * 0.8f + 0.1f, cos * 0.6f + 0.05f);
	}
}
