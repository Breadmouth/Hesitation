using UnityEngine;
using System.Collections;

public class LightScript2 : MonoBehaviour {

	public Light lt;
	public float angle;
	public float time;
	public float lightIntensity;
	public float cos;
	
	// Use this for initialization
	void Start () {
		lt = GetComponent<Light> ();
		angle = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time = 20 * Time.deltaTime;
		angle += time;
		lightIntensity = -1 * Mathf.Sin (angle * Mathf.PI / 180);
		cos = 0.3f * Mathf.Cos (angle * Mathf.PI / 180 );
		lt.intensity = lightIntensity * Mathf.Abs(cos);

	}
}
