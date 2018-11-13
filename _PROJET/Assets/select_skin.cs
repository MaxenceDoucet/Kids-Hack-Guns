using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class select_skin : MonoBehaviour, ISelectHandler {

	public GameObject selfSkin;
	public GameObject otherSkin1;
	public GameObject otherSkin2;

	public void OnSelect(BaseEventData eventData)
    	{
        	selfSkin.SetActive(true);
		otherSkin1.SetActive(false);
		otherSkin2.SetActive(false);
		
    	}
}
