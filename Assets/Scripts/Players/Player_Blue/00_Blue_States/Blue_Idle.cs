using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Idle : MonoBehaviour
{
    // Player Controller
    private BluePlayerController bluePlayerController;

    // Movement
    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    //======================================

    void OnEnable()
    {
        //Debug.Log("Idle_State");

        // Player Controller
        bluePlayerController = GetComponent<BluePlayerController>();

        // Move Player 
        myRigidbody = GetComponent<Rigidbody>();

        myRigidbody.velocity = Vector3.zero;    // Stop Movement

        // Enable Firing
        GetComponent<BlueFiringPrimary>().enabled = true;
    }

    //======================================

    void Update()   // State Transitions
    {
        //======================================

        // IDLE to RUNNING
        if ((Input.GetAxisRaw("Horizontal") != 0) || (Input.GetAxisRaw("Vertical") != 0)
            ||
           (Input.GetAxisRaw("Key_X") != 0) || (Input.GetAxisRaw("Key_Y") != 0))
        {
            // If player uses movement inputs, run:
            this.enabled = false;
            GetComponent<Blue_Running>().enabled = true;
        }

        // IDLE to WARP
        if ((Input.GetAxis("LTrigger") > 0 && bluePlayerController.deploy_1 != Vector3.zero) || (Input.GetKeyDown("e") && bluePlayerController.deploy_1 != Vector3.zero))
        {
            if (GetComponent<Blue_Warp>().triggerDown == false)
            {
                this.enabled = false;
                GetComponent<Blue_Warp>().enabled = true;
            }
        }

        // Reset Warp Trigger
        if (Input.GetAxis("LTrigger") <= 0)
        {
            GetComponent<Blue_Warp>().triggerDown = false;
        }

        // IDLE to DAMAGED
        if (GetComponent<Blue_Damaged>().enabled == true)
        {
            this.enabled = false;
        }
    }

}