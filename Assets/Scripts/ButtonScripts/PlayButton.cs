using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour, IPointerClickHandler {
    public void OnPointerClick(PointerEventData e)
    {
        //到ChooseLevelScene
        UnityEngine.Debug.Log("Play or Replay Button Clicked.");
        SceneManager.LoadScene(1);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
