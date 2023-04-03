using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Digital Twin Forest Team
 * Purpose: WASD movement
 */

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = transform.right * x + Camera.main. transform.forward * z;
        controller.Move(direction * speed * Time.deltaTime);
    }
}
