using UnityEngine;
using System.Collections;

public class barrel : MonoBehaviour {

	public bool up;
	// Use this for initialization
	void Start () 
	{
		up = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y <= 0.2f && up == true) 
		{
			if (transform.position.y >= 0.1f)
				up = false;

			transform.position += new Vector3 (0, 0.02f, 0);
		}

		if (transform.position.y >= -1.2f && up == false) 
		{
			if (transform.position.y <= -1.1f)
				up = true;

			transform.position -= new Vector3 (0, 0.02f, 0);
		}
	}
}
