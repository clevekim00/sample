using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed;
	public float _hp;
	public float _hpMax;
	
	public UIFilledSprite _hpBar;
	
	int height;
	
	public GameObject _Misile;

	// Use this for initialization
	void Start () {
		height = Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up"))
		{
			if (transform.position.y < 0.7)
			{
				transform.position += new Vector3(0, speed * Time.deltaTime, 0);
			}
		}
		else if (Input.GetKey("down"))
		{
			if (transform.position.y > -0.7)
			{
				transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
			}
		}
		else if (Input.GetKey("left"))
		{
			Debug.Log("x:" + transform.position.x);
			
			if (transform.position.x > -0.8)
			{
				transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
			}
		}
		else if (Input.GetKey("right"))
		{
			Debug.Log("x:" + transform.position.x);
			
			if (transform.position.x < 0.9)
			{
				transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
			}
		}
		else if (Input.GetKey("s"))
		{
			_Misile = new GameObject();
			_Misile.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
		}
	}
	
	public void OnTriggerEnter()
	{
		_hp -= 10.0F;
		_hpBar.fillAmount = _hp * 0.01F;
		
		if (_hp < 0)
		{
			GameEnd();
		}
	}
	
	void GameEnd()
	{
		Debug.Log("Game End");
		Time.timeScale = 0;
	}
}
