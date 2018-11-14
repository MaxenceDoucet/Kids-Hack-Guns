using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class select_klasse : MonoBehaviour {

	public Button Button1;
	public Button Button2;
	public Button Button3;
	public Button Button4;
	public Button Button5;

	public GameObject Background1;
	public GameObject Background2;
	public GameObject Background3;
	public GameObject Background4;
	public GameObject Background5;

	private int selected_Background;

	void Start()
	{
		selected_Background = 1;
		Button1 = GameObject.FindGameObjectWithTag("ButtonBackground1").GetComponent<Button>();
		Button1.onClick.AddListener ((UnityEngine.Events.UnityAction)this.GoBackground1);
		Button2 = GameObject.FindGameObjectWithTag("ButtonBackground2").GetComponent<Button>();
		Button2.onClick.AddListener ((UnityEngine.Events.UnityAction)this.GoBackground2);
		Button3 = GameObject.FindGameObjectWithTag("ButtonBackground3").GetComponent<Button>();
		Button3.onClick.AddListener ((UnityEngine.Events.UnityAction)this.GoBackground3);
		Button4 = GameObject.FindGameObjectWithTag("ButtonBackground4").GetComponent<Button>();
		Button4.onClick.AddListener ((UnityEngine.Events.UnityAction)this.GoBackground4);
		Button5 = GameObject.FindGameObjectWithTag("ButtonBackground5").GetComponent<Button>();
		Button5.onClick.AddListener ((UnityEngine.Events.UnityAction)this.GoBackground5);
	}
	
	void Update()
	{
		if(selected_Background == 1)
		{
			Background1.SetActive(true);
			Background2.SetActive(false);
			Background3.SetActive(false);
			Background4.SetActive(false);
			Background5.SetActive(false);
			Button1.Select();
 			Button1.OnSelect(null);
		}
		if(selected_Background == 2)
		{
			Background1.SetActive(false);
			Background2.SetActive(true);
			Background3.SetActive(false);
			Background4.SetActive(false);
			Background5.SetActive(false);
			Button2.Select();
 			Button2.OnSelect(null);
		}
		if(selected_Background == 3)
		{
			Background1.SetActive(false);
			Background2.SetActive(false);
			Background3.SetActive(true);
			Background4.SetActive(false);
			Background5.SetActive(false);
			Button3.Select();
 			Button3.OnSelect(null);
		}
		if(selected_Background == 4)
		{
			Background1.SetActive(false);
			Background2.SetActive(false);
			Background3.SetActive(false);
			Background4.SetActive(true);
			Background5.SetActive(false);
			Button4.Select();
 			Button4.OnSelect(null);
		}
		if(selected_Background == 5)
		{
			Background1.SetActive(false);
			Background2.SetActive(false);
			Background3.SetActive(false);
			Background4.SetActive(false);
			Background5.SetActive(true);
			Button5.Select();
 			Button5.OnSelect(null);
		}
	}

	public void GoBackground1()
	{
		selected_Background = 1;
	}

	public void GoBackground2()
	{
		selected_Background = 2;
	}

	public void GoBackground3()
	{
		selected_Background = 3;
	}

	public void GoBackground4()
	{
		selected_Background = 4;
	}

	public void GoBackground5()
	{
		selected_Background = 5;
	}
}
