using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: Digital Twin Forest Team
 * Purpose: Change from main page to the forest model
 */

public class UIToForestSceneManager : MonoBehaviour
{
    public void goToForestScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Forest", LoadSceneMode.Additive);
    }
}
