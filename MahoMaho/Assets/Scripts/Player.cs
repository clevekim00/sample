using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up"))
		{
			transform.position += new Vector3(0, speed * Time.deltaTime, 0);
		}
		else if (Input.GetKey("down"))
		{
			transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
		}
		
	}
}
