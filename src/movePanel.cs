using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: The sliding animation of panels
 */

public class movePanel : MonoBehaviour
{
    private float speed = 2000f;
    private float speed2 = -2000f;
    private bool isActive = false;
    private bool isShown = false;
    private bool isActive2 = false;
    private bool isShown2 = false;
    private int l_boundary = -400;
    private int r_boundary = 350;
    private int l_boundary2 = 3100;
    private int r_boundary2 = 3850;
    public GameObject go;
    public GameObject go2;

    public void myClick()
    {
        if (atLBoundary())
        {
            isActive = true;
            isShown = false;
        }
        else
        {
            isActive=false;
            isShown = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (isActive&&!isShown)
        {
            go.transform.Translate(speed * Time.deltaTime, 0, 0);
            float x = go.transform.position.x;
            if (x >= r_boundary)
            {
                isShown = true;
            }

        }
        else if (!isActive &&!isShown)
        {

            go.transform.Translate(-speed * Time.deltaTime, 0, 0);
            float x = go.transform.position.x;
            if (x <= l_boundary)
            {
                isShown = true;
            }
        }
        ///
        if (isActive2 && !isShown2)
        {
            go2.transform.Translate(speed2 * Time.deltaTime, 0, 0);
            float x2 = go2.transform.position.x;
            if (x2 <= l_boundary2)
            {
                isShown2 = true;
            }
        }
        else if (!isActive2 && !isShown2)
        {

            go2.transform.Translate(-speed2 * Time.deltaTime, 0, 0);
            float x2 = go2.transform.position.x;
            if (x2 >= r_boundary2)
            {
                isShown2 = true;
            }
        }
    }

    public bool atLBoundary()
    {
        float x = go.transform.position.x;
        return x<=l_boundary;
    }
    /// <summary>
    /// ----------------------------
    /// </summary>

    public void myClick2()
    {
        if (atRBoundary2())
        {
            isActive2 = true;
            isShown2 = false;
        }
        else
        {
            isActive2 = false;
            isShown2 = false;
        }

    }
    public bool atRBoundary2()
    {
        float x = go2.transform.position.x;
        return x >= r_boundary2;
    }

}
