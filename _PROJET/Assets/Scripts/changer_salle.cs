using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changer_salle : MonoBehaviour {
	public string Scene_name;
	public void ChangeScene()
	{
		SceneManager.LoadScene(Scene_name);
	}
}