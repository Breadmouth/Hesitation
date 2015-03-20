/*
        Unity 3D: Level GUI Script Source for State Manager
       
    Copyright 2012 FIZIX Digital Agency
    http://www.fizixstudios.com
       
        For more information see the tutorial at:
    http://www.fizixstudios.com/labs/do/view/id/unity-game-state-manager
       
       
    Notes:
        This script is a C# script provides a simple GUI that interfaces with the state manager, you.
        will need the statemanager.cs script and should review the gamestart.cs script for information
        on how to implement the state manager.
*/



using UnityEngine;
using System.Collections;

public class PlayState : MonoBehaviour 
{
	
	// Initialize level
	void Start ()
	{
		print ("Loaded: " + gamestate.Instance.getLevel());
	}

	void Update()
	{

	}



	// ---------------------------------------------------------------------------------------------------
	// OnGUI()
	// ---------------------------------------------------------------------------------------------------
	// Provides a GUI on level scenes
	// ---------------------------------------------------------------------------------------------------
	void OnGUI()
	{              
		// Create buttons to move between level 1 and level 2


		if (Input.GetKey(KeyCode.Space))
		{
			GUI.Label(new Rect(200, 200, 200, 200), "BANG");
		}

	}
}
