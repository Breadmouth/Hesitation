﻿/*
        Unity 3D: Game State Manager Script Source for State Manager
       
    Copyright 2012 FIZIX Digital Agency
    http://www.fizixstudios.com
       
        For more information see the tutorial at:
    http://www.fizixstudios.com/labs/do/view/id/unity-game-state-manager
       
       
    Notes:
        This script is a C# game state manager for Unity 3D; you should review the gamestart.cs
        script to help understand how to implement game states.
*/



using UnityEngine;
using System.Collections;

public class gamestate : MonoBehaviour {
	
	// Declare properties
	private static gamestate instance;
	private string activeLevel;                     // Active level
	private string name;                            // Characters name
	private int maxHP;                                      // Max HP
	private int maxMP;                                      // Map MP
	private int hp;                                         // Current HP
	private int mp;                                         // Current MP
	private int str;                                        // Characters Strength
	private int vit;                                        // Characters Vitality
	private int dex;                                        // Characters Dexterity
	private int exp;                                        // Characters Experience Points
	
	
	
	// ---------------------------------------------------------------------------------------------------
	// gamestate()
	// ---------------------------------------------------------------------------------------------------
	// Creates an instance of gamestate as a gameobject if an instance does not exist
	// ---------------------------------------------------------------------------------------------------
	public static gamestate Instance
	{
		get
		{
			if(instance == null)
			{
				instance = new GameObject("gamestate").AddComponent<gamestate> ();
			}
			
			return instance;
		}
	}      
	
	// Sets the instance to null when the application quits
	public void OnApplicationQuit()
	{
		instance = null;
	}
	// ---------------------------------------------------------------------------------------------------
	
	
	// ---------------------------------------------------------------------------------------------------
	// startState()
	// ---------------------------------------------------------------------------------------------------
	// Creates a new game state
	// ---------------------------------------------------------------------------------------------------
	public void startState()
	{
		print ("Creating a new game state");
		
		// Set default properties:
		activeLevel = "Level 1";
		name = "My Character";
		maxHP = 250;
		maxMP = 60;
		hp = maxHP;
		mp = maxMP;
		str = 6;
		vit = 5;
		dex = 7;
		exp = 0;
		
		// Load level 1
		Application.LoadLevel("level1");
	}
	
	
	
	// ---------------------------------------------------------------------------------------------------
	// getLevel()
	// ---------------------------------------------------------------------------------------------------
	// Returns the currently active level
	// ---------------------------------------------------------------------------------------------------
	public string getLevel()
	{
		return activeLevel;
	}
	
	
	// ---------------------------------------------------------------------------------------------------
	// setLevel()
	// ---------------------------------------------------------------------------------------------------
	// Sets the currently active level to a new value
	// ---------------------------------------------------------------------------------------------------
	public void setLevel(string newLevel)
	{
		// Set activeLevel to newLevel
		activeLevel = newLevel;
	}
	
	
	// ---------------------------------------------------------------------------------------------------
	// getName()
	// ---------------------------------------------------------------------------------------------------
	// Returns the characters name
	// ---------------------------------------------------------------------------------------------------
	public string getName()
	{
		return name;
	}
	
	
	// ---------------------------------------------------------------------------------------------------
	// getHP()
	// ---------------------------------------------------------------------------------------------------
	// Returns the characters hp
	// ---------------------------------------------------------------------------------------------------
	public int getHP()
	{
		return hp;
	}
	
	// ---------------------------------------------------------------------------------------------------
	// getMP()
	// ---------------------------------------------------------------------------------------------------
	// Returns the characters mp
	// ---------------------------------------------------------------------------------------------------
	public int getMP()
	{
		return mp;
	}
}
