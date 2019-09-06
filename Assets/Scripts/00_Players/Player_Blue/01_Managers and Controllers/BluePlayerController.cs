using UnityEngine;

using System.Collections;


public class BluePlayerController : MonoBehaviour 
{
    [Header("Initialized Variables")]

    // Movement
    //public float moveSpeed;
    private Rigidbody myRigidbody;

    public Vector3 moveInput;
    public Vector3 moveVelocity;

    // Can Shoot / Can Act
    public bool canShoot = true;

    // Can Be Damaged
    public bool canBeDamaged;

    // Camera 
    private Camera mainCamera;

    // Gun
    public BlueGunController theGun;

    // Warp Points
    public GameObject deploy_1_ID;
    public GameObject deploy_2_ID;
    public Vector3 deploy_1;
    public Vector3 deploy_2;

    // Heals
    public int blueHeals = 3;

    // Associated Sprite Object
    public GameObject spriteObject;

    // Sprite Animator
    Animator Animator;

    // GamePad or Mouse
    public bool useController;

    //======================================

    void Awake()
    {
        Animator = spriteObject.GetComponent<Animator>();

        // Can Be Damaged
        canBeDamaged = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
        // Enter Idle State
        GetComponent<Blue_Idle>().enabled = true;
    }
}

//======================================

/*

A
joystick button 0

B
joystick button 1

X
joystick button 2

Y
joystick button 3

Left Bumper
joystick button 4

Right Bumper
joystick button 5


View(Back)
joystick button 6

Menu(Start)
joystick button 7

Left Stick Button
joystick button 8

Right Stick Button
joystick button 9

Left Stick “Horizontal”
X Axis
-1 to 1

Left Stick “Vertical”
Y Axis
1 to -1

Right Stick “HorizontalTurn”
4th Axis
-1 to 1

Right Stick “VerticalTurn”
5th Axis
1 to -1

DPAD – Horizontal
6th Axis
-1 (.64) 1

DPAD – Vertical
7th Axis
-1 (.64) 1

Left Trigger
9th Axis
0 to 1

Right Trigger
10th Axis
0 to 1

Left Trigger Shared Axis
3rd Axis
0 to 1

Right Trigger Shared Axis
3rd Axis
0 to -1

*/ // GAME PAD LEGEND