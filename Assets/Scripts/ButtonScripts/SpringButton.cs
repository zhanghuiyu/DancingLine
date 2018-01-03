using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SpringButton : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData e)
    {
        //到SpringGameScene
        UnityEngine.Debug.Log("Spring Button Clicked.");
        SceneManager.LoadScene(2);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
