using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDeployableInteract : MonoBehaviour
{
    public BluePlayerController bluePlayer;

    public float counterCanInteract = 2f;

    public float returnDeployDoubleTapCounter = 0f;

    public AudioClip sfx;

    public AudioSource sfxReturnDeploy;

    public SpriteRenderer _sprite;

    public bool isDetroyed = true;

    public bool sfxReturnDeployTrigger = false;

    public bool touchingBlue = false;

    public bool blueUpgrading = false;

    private int blueUpgradeMeterMAX = 1;

    public float blueUpgradeMeter = 1;

    public int blueUpgradeMeterCounter = 0;

    public int buttonPresses = 0;

    private void Awake()
    {
        bluePlayer = GameObject.FindGameObjectWithTag("Blue_Player").GetComponent<BluePlayerController>();
    }

    private void Update()
    {
        // Count Down for Sprite Interaction
        if (counterCanInteract > 0)
        {
            counterCanInteract -= Time.deltaTime;
        }

        // Count Down for Double Tap Return Deploy
        if (returnDeployDoubleTapCounter > 0)
        {
            returnDeployDoubleTapCounter -= Time.deltaTime;
        }

        if (returnDeployDoubleTapCounter < 0)
        {
            returnDeployDoubleTapCounter = 0;
            buttonPresses = 0;
        }

        // Upgrade Mini Game Meter

        // Double Tap "A" Counter
        if (touchingBlue == true)
        {
            // A Button - Take Back Deploy // Upgrade Deploy
            if (blueUpgrading == false)
            {
                // Take Back
                if ((Input.GetKeyDown(KeyCode.Joystick1Button0)) || (Input.GetKeyDown("space")) & (buttonPresses == 0))
                {
                    returnDeployDoubleTapCounter = .35f;
                    buttonPresses += 1;
                }

                if ((buttonPresses == 2) & (returnDeployDoubleTapCounter > 0))
                {
                    bluePlayer.theGun.barrierCounter -= 1;
                    buttonPresses = 0;
                    Destroy(gameObject);
                }

                // Upgrade
                if ((Input.GetKeyDown(KeyCode.Joystick1Button3)) || (Input.GetKeyDown("q")))
                {
                    blueUpgrading = !blueUpgrading;
                }

            }

            // Upgrading Mini Game Rules
            if (blueUpgrading == true)
            {
                if (blueUpgradeMeter > 0)
                {
                    blueUpgradeMeter -= Time.deltaTime;
                }

                // Reset Meter
                if (blueUpgradeMeter <= 0)
                {
                    blueUpgradeMeter = blueUpgradeMeterMAX;
                }

                // Upgrade on Beat
                if (((Input.GetKeyDown(KeyCode.Joystick1Button3)) || (Input.GetKeyDown("q"))) & ((blueUpgradeMeter >= 0f) & (blueUpgradeMeter <= .5f)))
                {
                    Debug.Log("UPGRADE +1");
                    blueUpgradeMeterCounter += 1;
                }

                // MISS Beat
                if (((Input.GetKeyDown(KeyCode.Joystick1Button3)) || (Input.GetKeyDown("q"))) & ((blueUpgradeMeter < 0f) || (blueUpgradeMeter <= .5f)))
                {
                    blueUpgradeMeter = blueUpgradeMeterMAX;
                    blueUpgrading = false;
                }

                // Cancel Upgrade Mini Game
                if ((Input.GetKeyDown("space")) || (Input.GetKeyDown(KeyCode.Joystick1Button1)))
                {
                    blueUpgradeMeter = blueUpgradeMeterMAX;
                    blueUpgrading = false;
                }

            }
        }
    }

    //Detect collisions between the GameObjects with Colliders attached
    private void OnTriggerStay(Collider other)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.name == "Player_Blue" & counterCanInteract <= 0)
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            //Debug.Log("Do something here");

            touchingBlue = true;

            _sprite.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.name == "Player_Blue")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            //Debug.Log("Do something here");

            blueUpgradeMeter = 0;

            blueUpgrading = false;

            touchingBlue = false;

            _sprite.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    // Disarm On Destroy Event
    void OnApplicationQuit()
    {
        isDetroyed = false;
    }

    void OnDestroy()
    {
        if (isDetroyed == true)
        {
            Destroy(transform.parent.gameObject);
        }
    }



}