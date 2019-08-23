using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTurretController : MonoBehaviour
{
    [Header("Initialized Variables")]

    public BluePlayerController bluePlayer;

    public BlueGunController blueGun;

    public Animator anim;

    public bool holding;

    public float lifeTime;

    ///

    void Awake() // INITIALIZE VARIABLES
    {
        blueGun = GameObject.FindGameObjectWithTag("Blue_Gun").GetComponent<BlueGunController>();

        bluePlayer = GameObject.FindGameObjectWithTag("Blue_Player").GetComponent<BluePlayerController>();
    }

    void Start()
    {
        holding = true;

        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //if (blueGun.holdingBarrier == true  && holding == false)
        {
            if (holding == true)
            {
                transform.position = blueGun.barrierDeployPoint.position; // Lock to Blue while Chargine
                        
                var lookPos = -(bluePlayer.transform.position - transform.position);
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 1);

                //anim.SetTrigger("Active");
            }
        }

        // Destroy Over Time
        if (holding == false)
        {
            lifeTime -= Time.deltaTime;  // Destroy over time
        }
       
        if (lifeTime <= 0)
        {
            blueGun.barrierCounter -= 1;
            Destroy(gameObject);
        }

        if (Input.GetMouseButtonUp(2) || Input.GetKeyUp(KeyCode.Joystick1Button4))
        {
            holding = false;
            anim.SetTrigger("Active");
        }

    }
}
