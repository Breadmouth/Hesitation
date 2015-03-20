using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour 
{

	public GameObject BulletPrefab;
	public bool dir;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.LeftControl)) 
		{
			if (!dir)
			{
				GameObject Bullet = (GameObject) Instantiate(BulletPrefab, transform.position, transform.rotation);
				Bullet.SendMessage("test", dir);
			}
		}

		if (Input.GetKeyDown (KeyCode.RightControl)) 
		{
			if (dir)
			{
				GameObject Bullet = (GameObject) Instantiate(BulletPrefab, transform.position, transform.rotation);
				Bullet.SendMessage("test", true);
			}
		}

	}
}
