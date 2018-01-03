﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class WinterButton : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData e)
    {
        //到WinterGameScene
        UnityEngine.Debug.Log("Winter Button Clicked.");
        SceneManager.LoadScene(3);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
