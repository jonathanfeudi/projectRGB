using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBarrierController : MonoBehaviour
{
    [Header("Initialized Variables")]

    public BluePlayerController bluePlayer;

    public BlueGunController blueGun;

    public Animator anim;

    private bool holding;

    public float lifeTime;

    public Vector3 _position;

    public bool warpSelectionOn = false;

    public GameObject warpPoint;

    public Light warpLight;

    public Color warpColor;

    public bool _selected = false;

    public static GameObject instance;

    ///

    void Awake() // INITIALIZE VARIABLES
    {
        blueGun = GameObject.FindGameObjectWithTag("Blue_Gun").GetComponent<BlueGunController>();

        bluePlayer = GameObject.FindGameObjectWithTag("Blue_Player").GetComponent<BluePlayerController>();

        instance = this.gameObject;

        warpColor = warpLight.color;
    }

    void Start()
    {
        holding = true;

        anim = gameObject.GetComponent<Animator>();

        // Set Warp Points

        _position = warpPoint.transform.position;

        if (bluePlayer.deploy_1 == Vector3.zero)
        {
            bluePlayer.deploy_1 = _position;
            bluePlayer.deploy_1_ID = instance;
        }
        else
        {
            bluePlayer.deploy_2 = _position;
            bluePlayer.deploy_2_ID = instance;
        }
    }

    void Update()
    {
        // Blue Has Deployable Armed
        if (holding == true)
        {
            transform.position = blueGun.barrierDeployPoint.position; // Lock to Blue while Chargine
                        
            var lookPos = bluePlayer.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 1);
        }

        // Deploy
        if (Input.GetMouseButtonUp(1) || Input.GetKeyUp(KeyCode.Joystick1Button5))
        {
            holding = false;
            anim.SetTrigger("Active");
        }

        // Warp Indicator On
        if ((bluePlayer.GetComponent<Blue_Warp>().enabled == true) & _selected == true)
        {
            warpSelectionOn = true;
            warpLight.enabled = true;
        }
        else
        {
            warpSelectionOn = false;
            warpLight.enabled = false;
        }

        // Change Color
        if (bluePlayer.GetComponent<Blue_Warp>().altWarp == true)
        {
            warpLight.color = Color.yellow;
        }
        else
        {
            warpLight.color = warpColor;
        }

    }

    // Play SFX
    void PlaySFX()
    {
        GetComponent<AudioSource>().Play();
    }
}
