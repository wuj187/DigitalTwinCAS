using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeParaDispButtonHandler : MonoBehaviour
{
    private bool isActive = false;
    public Image TreeParamDisp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TreeParamDispHandle()
    {
        if(!isActive)
        {
            TreeParamDisp.gameObject.SetActive(true);
            isActive = !isActive;
        }
        else
        {
            TreeParamDisp.gameObject.SetActive(false);
            isActive = !isActive;
        }
    }
}
