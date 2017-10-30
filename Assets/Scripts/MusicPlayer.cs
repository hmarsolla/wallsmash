﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;

	// Use this for initialization
	void Awake ()
	{
		if(instance != null)
		{
			Destroy (gameObject);
		} 
		else
		{
			instance = this;	
			GameObject.DontDestroyOnLoad (gameObject);	
		}
	}
}
