using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMain : MonoBehaviour {

	void Update () {
		if (GvrController.AppButtonUp) {
			SceneManager.LoadScene("BeatBeans", LoadSceneMode.Single);
		}
	}
}
