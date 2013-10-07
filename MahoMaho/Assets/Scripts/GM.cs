using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {
	
	public GameObject _BgSetObj;
	
	public float      _moveSpeed;
	public float      _moveSpeedMax;
	
	float _xPosMoveChk  = 0F;
	float _xPosMoveChk2 = 0F;
	
	public float   _timerLim;
	public float   _timerForSpped;
	
	public UILabel _score;
	public int     _gameScore;
	public int     _gameScorePer;
	
	// Use this for initialization
	void Start () {
		_gameScorePer = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
		_timerForSpped += Time.deltaTime;
		if (_timerForSpped > _timerLim)
		{
			_timerForSpped = 0;
			if (_moveSpeed < _moveSpeedMax)
			{
				_moveSpeed = _moveSpeed * 1.1f;
			}
		}
		
		_xPosMoveChk  += _moveSpeed * Time.deltaTime;
		_xPosMoveChk2 += _moveSpeed * Time.deltaTime * 0.5F;
		
		_BgSetObj.transform.localPosition += new Vector3(_moveSpeed * -1F * Time.deltaTime * 0.5F, 0, 0);
		
		if (_xPosMoveChk >= (960.0F + 960.0F / 2.0F))
		{
			_xPosMoveChk = 0F;
			_BgSetObj.transform.localPosition = new Vector3(960.0F * -1F, 0, 0);
			
			_gameScore += _gameScorePer;
			_score.text = _gameScore.ToString();
		}
	}
}
