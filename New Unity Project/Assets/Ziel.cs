﻿using UnityEngine;
using System.Collections;

public class Ziel : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == Player.tag) {
			Application.LoadLevel(0);
		}
	}
}
