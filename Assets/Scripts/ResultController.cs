using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shareArea
{
    public static bool gameResult = false; //記錄輸贏
}

public class ResultController : MonoBehaviour {
    Text showResult; //顯示輸贏

	// Use this for initialization
	void Start () {
        showResult = GetComponent<Text>();
        if (shareArea.gameResult)
            showResult.text = "You Win";
        else
            showResult.text = "You Lose";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
