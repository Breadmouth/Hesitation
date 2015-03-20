using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour 
{
	public Rigidbody Bullet;
	public bool isShootingLeft;
	// Use this for initialization
	void Start () 
	{

	}

	public void test(bool direction)
	{
		isShootingLeft = direction;
	}
	
	// Update is called once per frame
	void Update () 
	{
	//	Bullet.velocity = new Vector3(1, 0, 0);

		if (isShootingLeft) 
			this.transform.position += new Vector3 (-0.02f, 0, 0);
	
		else 
			this.transform.position -= new Vector3( -0.02f, 0, 0);

		if(this.transform.position.x <= -3)
		{
			GUI.Label(new Rect(200, 200, 200, 200), "player wins");
			print("player 1 wins");
			Destroy (gameObject);
		}

		if(this.transform.position.x >= 3)
		{
			GUI.Label(new Rect(200, 200, 200, 200), "player wins");
			print("player 2 wins");
			Destroy (gameObject);
		}

	}
}
