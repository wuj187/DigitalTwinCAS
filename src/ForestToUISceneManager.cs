using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: Digital Twin Forest Team
 * Purpose: From forest model to the main page
 */

public class ForestToUISceneManager : MonoBehaviour
{
    public treePlanting treePlanter;

    public void Plot14ToMain()
    {
        // before going back to the main page, clear all the trees in the previous scene 
        treePlanter.cleanTrees();
        SceneManager.UnloadScene(1);

        //treePlanter.cleanTrees();
    }
}
