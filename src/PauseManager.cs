using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: Pause the system (mouse is disconnected with the camera)
 */

public class PauseManager : MonoBehaviour
{
    public bool isPaused = false;
    public Image pauseIndicator;

    // Start is called before the first frame update
    void Start()
    {
        pauseIndicator.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(!isPaused)
            {
                //Time.timeScale = 0;
                pauseIndicator.gameObject.SetActive(true);
                isPaused = !isPaused;
            }
            else
            {
                //Time.timeScale = 1;
                pauseIndicator.gameObject.SetActive(false);
                isPaused = !isPaused;
            } 
        }        
    }
}
