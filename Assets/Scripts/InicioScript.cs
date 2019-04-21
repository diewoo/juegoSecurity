using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour {

	// Load Scene 01 when start button is pressed
	public void StartGame()
	{
		SceneManager.LoadScene ("Scene01");
	}

	
	public void GotoToMainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}


}
