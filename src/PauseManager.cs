using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;
    public Text pauseMessage;

    // Start is called before the first frame update
    void Start()
    {
        pauseMessage.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(!isPaused)
            {
                Time.timeScale = 0;
                pauseMessage.text = "Paused";
                isPaused = !isPaused;
            }
            else
            {
                Time.timeScale = 1;
                pauseMessage.text = "";
                isPaused = !isPaused;
            } 
        }        
    }
}
