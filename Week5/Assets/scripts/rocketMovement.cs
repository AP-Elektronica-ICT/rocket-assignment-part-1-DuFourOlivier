using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class rocketMovement : MonoBehaviour
{
    [SerializeField] Transform trans;
    [SerializeField] Rigidbody rg;

    private bool jump;

    private void Start()
    {
       
    }
    private void Update()
    {
        float vert = CrossPlatformInputManager.GetAxis("Vertical");
        rg.AddForce(0, vert, 0);

        float hor = CrossPlatformInputManager.GetAxis("Horizontal");
        trans.Rotate(hor * 3f, 0, 0);

        jump = CrossPlatformInputManager.GetButton("Jump");
        if (jump)
        {
            rg.AddRelativeForce(0,40,0);
        }
    }
}
