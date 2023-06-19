using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    bool isGrounded = false;
    float defaultSphereSpeed = -3;
    [SerializeField] float multiplierSphereSpeed = 1;

    void FixedUpdate()
    {
        MoveSphereOnGround();
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
            isGrounded = true;
    }

    private void MoveSphereOnGround()
    {
        if (isGrounded)
            transform.Translate(0, 0, defaultSphereSpeed * multiplierSphereSpeed * Time.deltaTime);
    }
}
