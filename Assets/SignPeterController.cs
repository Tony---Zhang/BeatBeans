using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SignPeterController : MonoBehaviour {

	public void OnPointerEvent(bool isFocus) {
		if (isFocus) {
			Console.WriteLine ("Focus");
		} else {
			Console.WriteLine ("Blur");
		}
	}
}
