﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class RockController : MonoBehaviour {
    //偵測Line的觸碰
    void OnTriggerEnter(Collider collider)
    {
        switch (collider.gameObject.name)
        {
            case "Cube_Spring(Clone)":
                shareArea.gameResult = false;
                shareData_Spring.gameStart = false;
                shareData_Spring.timer.Reset();
                break;
            case "Cube_Winter(Clone)":
                shareArea.gameResult = false;
                shareData_Winter.gameStart = false;
                shareData_Winter.timer.Reset();
                break;
            default:
                break;
        }
        UnityEngine.Debug.Log("The Line Touched Rock.");
        SceneManager.LoadScene(4);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
