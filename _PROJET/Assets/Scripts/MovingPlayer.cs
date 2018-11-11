using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour {

	public static MovingPlayer Singleton;

	private void Awake()
	{
		if (Singleton != null)
		{
			Destroy(gameObject);
		}
		else
		{
			Singleton = this;
		}
	}
	
	public bool IsInAttack;
	public GameObject CameraOutOfAttack;
	public GameObject CameraForAttack;
	public GameObject CameraPlayer;
	
	void Start()
	{
		IsInAttack = false;
		CameraOutOfAttack.SetActive(true);
		CameraForAttack.SetActive(false);
	}
	
	public void AttackMode()
	{
		IsInAttack = !IsInAttack;
		if (IsInAttack == true)
		{
			CameraOutOfAttack.SetActive(false);
			CameraForAttack.SetActive(true);
			CameraForAttack.transform.position = CameraPlayer.transform.position;
		}
		if (IsInAttack == false)
		{
			CameraOutOfAttack.SetActive(true);
			CameraForAttack.SetActive(false);
		}
	}

}
