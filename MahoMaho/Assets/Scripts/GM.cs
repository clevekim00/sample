using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {
	
	public GameObject _BgSetObj;
	public float      _moveSpeed;
	
	float _xPosMoveChk = 0F;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_xPosMoveChk += _moveSpeed * Time.deltaTime;
		
		_BgSetObj.transform.localPosition += new Vector3(_moveSpeed * -1F * Time.deltaTime, 0, 0);
		
		if (_xPosMoveChk > 960.0F)
		{
			_xPosMoveChk = 0F;
			_BgSetObj.transform.localPosition = new Vector3(960 * -1F, 0, 0);
		}
	}
}
