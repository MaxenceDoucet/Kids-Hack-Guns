using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class select_klasse : MonoBehaviour, ISelectHandler {

	public GameObject selfBackground;
	public GameObject otherBackground1;
	public GameObject otherBackground2;
	public GameObject otherBackground3;
	public GameObject otherBackground4;

	public void OnSelect(BaseEventData eventData)
    	{
        	selfBackground.SetActive(true);
		otherBackground1.SetActive(false);
		otherBackground2.SetActive(false);
		otherBackground3.SetActive(false);
		otherBackground4.SetActive(false);
		
    	}
}
