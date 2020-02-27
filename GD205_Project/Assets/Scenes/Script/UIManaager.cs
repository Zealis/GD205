using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManaager : MonoBehaviour
{
	GameObject[] pauseObjects;


	// Start is called before the first frame update
	void Start()
    {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
	}

    private void hidePaused()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

		//uses the p button to pause and unpause the game
		if (Input.GetKeyDown(KeyCode.P))
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			}
			else if (Time.timeScale == 0)
			{
				Debug.Log("high");
				Time.timeScale = 1;
				hidePaused();
			}
		}
	}

    private void showPaused()
    {
        throw new NotImplementedException();
    }
}
