using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
 * Author: Digital Twin Forest Team
 * Purpose: Simulate summer and winter season
 */

public class SeasonController : MonoBehaviour
{
    public bool haveLeaves = true;
    public treePlanting treePlanter;
    public Dropdown plotSelection;
    public Button seasonChangeBut;
    public Sprite summerImage;
    public Sprite winterImage;
    public ParticleSystem Snow;

    // set the initial season(summer)
    public void Awake()
    {
        seasonChangeBut.image.sprite = summerImage;
        Snow.gameObject.SetActive(false);
    }

    public void changeSeason()
    {   
        haveLeaves = !haveLeaves;
        if (haveLeaves)
        {
            Snow.gameObject.SetActive(false);
            seasonChangeBut.image.sprite = summerImage;
        }
        if (!haveLeaves)
        {
            Snow.gameObject.SetActive(true);
            seasonChangeBut.image.sprite = winterImage;
        }

        // after changing the season, we need to plant corresponding trees
        treePlanter.plantTrees(plotSelection.value);
    }
}
