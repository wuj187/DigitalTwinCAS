using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvDataDispButtonHandler : MonoBehaviour
{
    private bool isActive = false;
    public Image EnvDisp;           // act like the panel to display the environment data

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void EnvDataDispHandle()
    {
        if (!isActive)
        {
            EnvDisp.gameObject.SetActive(true);
            isActive = !isActive;
        }
        else
        {
            EnvDisp.gameObject.SetActive(false);
            isActive = !isActive;
        }
    }
}
