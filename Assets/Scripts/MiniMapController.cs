﻿using UnityEngine;
using System.Collections;

public class MiniMapController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("m")) {
			this.camera.enabled = !this.camera.enabled;
		}
	}
}
