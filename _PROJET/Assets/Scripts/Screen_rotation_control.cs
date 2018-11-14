using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_rotation_control : MonoBehaviour {

	public bool PortraitAutorise;
	public bool PortraitInverseAutorise;
	public bool PaysageAutorise;
	public bool PaysageInverseAutorise;
	
	
	// Use this for initialization
	void Start () {
		Screen.autorotateToPortrait = PortraitAutorise;
		Screen.autorotateToPortraitUpsideDown = PortraitInverseAutorise;
		Screen.autorotateToLandscapeLeft = PaysageAutorise;
		Screen.autorotateToLandscapeRight = PaysageInverseAutorise;

		Screen.orientation = ScreenOrientation.AutoRotation;		
	}
}
