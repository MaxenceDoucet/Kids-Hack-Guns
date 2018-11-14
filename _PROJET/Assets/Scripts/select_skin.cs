using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class select_skin : MonoBehaviour {

	public Button ButtonPrevious;
	public Button ButtonNext;

	public GameObject Skin1;
	public GameObject Skin2;
	public GameObject Skin3;

	private int selected_skin;

	void Start()
	{
		selected_skin = 1;
		ButtonPrevious = GameObject.FindGameObjectWithTag("ButtonPrevious").GetComponent<Button>();
		ButtonPrevious.onClick.AddListener ((UnityEngine.Events.UnityAction)this.PreviousSkin);
		ButtonNext = GameObject.FindGameObjectWithTag("ButtonNext").GetComponent<Button>();
		ButtonNext.onClick.AddListener ((UnityEngine.Events.UnityAction)this.NextSkin);
	}
	
	void Update()
	{
		if(selected_skin == 1)
		{
			Skin1.SetActive(true);
			Skin2.SetActive(false);
			Skin3.SetActive(false);
		}
		if(selected_skin == 2)
		{
			Skin2.SetActive(true);
			Skin1.SetActive(false);
			Skin3.SetActive(false);
		}
		if(selected_skin == 3)
		{
			Skin3.SetActive(true);
			Skin2.SetActive(false);
			Skin1.SetActive(false);
		}
	}

	public void PreviousSkin()
	{
		selected_skin -= 1;
		if(selected_skin <= 0)
		{
			selected_skin = 3;
		}
	}
	public void NextSkin()
	{
		selected_skin += 1;
		if(selected_skin >= 4)
		{
			selected_skin = 1;
		}
	}
}
