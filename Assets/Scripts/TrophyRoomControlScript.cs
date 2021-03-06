﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyRoomControlScript : MonoBehaviour {

	// References to trophies game objects to control
	public GameObject cup1, cup2, cup3,cup4, cup5, cup6;

	// Variables to contain Player Prefs values
	int cup1Got, cup2Got, cup3Got,cup4Got, cup5Got, cup6Got;

	// Use this for initialization
	public void Start () {

		// Getting Player Prefs values to make sure you got
		// particular trophy
		cup1Got = PlayerPrefs.GetInt ("Cup1Got");
		cup2Got = PlayerPrefs.GetInt ("Cup2Got");
		cup3Got = PlayerPrefs.GetInt ("Cup3Got");	
		cup4Got = PlayerPrefs.GetInt ("Cup4Got");
		cup5Got = PlayerPrefs.GetInt ("Cup5Got");
		cup6Got = PlayerPrefs.GetInt ("Cup6Got");
		// If you got trophy 1
		if (cup1Got == 1)
			// then it is shown on the shelf
			cup1.SetActive (true);
		// if you don't get it
		else
			// then it is not shown
			cup1.SetActive (false);

		// Same for trophy 2 and 3
		if (cup2Got == 1)
			cup2.SetActive (true);
		else
			cup2.SetActive (false);
		
		if (cup3Got == 1)
			cup3.SetActive (true);
		else
			cup3.SetActive (false);

		if (cup4Got == 1)
			cup4.SetActive (true);
		else
			cup4.SetActive (false);			
		if (cup5Got == 1)
			cup5.SetActive (true);
		else
			cup5.SetActive (false);
		if (cup6Got == 1)
			cup6.SetActive (true);
		else
			cup6.SetActive (false);

	}

}
