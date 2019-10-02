using UnityEngine;

public class SwapEmission : MonoBehaviour
{
    // Warping Start Up
    public Texture2D Blue_Warping_StartUp;

    // Warping Choosing
    public Texture2D Blue_Warping_Choosing;

    // Movement
    public Texture2D EmissionMapTexture;
    public Texture2D EmissionMapTexture_00;
    public Texture2D EmissionMapTexture_02;
    public Texture2D EmissionMapTexture_04;
    public Texture2D EmissionMapTexture_06;

    // Roll
    public Texture2D EmissionMapTexture_Roll_00;
    public Texture2D EmissionMapTexture_Roll_02;
    public Texture2D EmissionMapTexture_Roll_04;
    public Texture2D EmissionMapTexture_Roll_06;

    // Fire Primary Idle
    public Texture2D EmissionMapTexture_Fire_Idle_0;
    public Texture2D EmissionMapTexture_Fire_Idle_1;
    public Texture2D EmissionMapTexture_Fire_Idle_2;
    public Texture2D EmissionMapTexture_Fire_Idle_3;
    public Texture2D EmissionMapTexture_Fire_Idle_4;
    public Texture2D EmissionMapTexture_Fire_Idle_5;
    public Texture2D EmissionMapTexture_Fire_Idle_6;
    public Texture2D EmissionMapTexture_Fire_Idle_7;

    // Fire Primary Run
    public Texture2D EmissionMapTexture_Fire_Run_0;
    public Texture2D EmissionMapTexture_Fire_Run_1;
    public Texture2D EmissionMapTexture_Fire_Run_2;
    public Texture2D EmissionMapTexture_Fire_Run_3;
    public Texture2D EmissionMapTexture_Fire_Run_4;
    public Texture2D EmissionMapTexture_Fire_Run_5;
    public Texture2D EmissionMapTexture_Fire_Run_6;
    public Texture2D EmissionMapTexture_Fire_Run_7;

    // Use this for initialization
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.material.EnableKeyword("_EMISSION");
    }


    void LateUpdate()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        //spriteRenderer.material.GetTexture("_MainTex");

        spriteRenderer.material.EnableKeyword("_EMISSION");

        // Warping Start Up
        if (spriteRenderer.sprite.name == "Blue_Warping_StartUp_0"
        || spriteRenderer.sprite.name == "Blue_Warping_StartUp_1"
        || spriteRenderer.sprite.name == "Blue_Warping_StartUp_2"
        || spriteRenderer.sprite.name == "Blue_Warping_StartUp_3"
        || spriteRenderer.sprite.name == "Blue_Warping_StartUp_4"
        || spriteRenderer.sprite.name == "Blue_Warping_StartUp_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", Blue_Warping_StartUp);
        }

        // Warping Choosing
        if (spriteRenderer.sprite.name == "Blue_Warping_Choosing_0"
        || spriteRenderer.sprite.name == "Blue_Warping_Choosing_1"
        || spriteRenderer.sprite.name == "Blue_Warping_Choosing_2"
        || spriteRenderer.sprite.name == "Blue_Warping_Choosing_3"
        || spriteRenderer.sprite.name == "Blue_Warping_Choosing_4"
        || spriteRenderer.sprite.name == "Blue_Warping_Choosing_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", Blue_Warping_Choosing);
        }

        // Movement

        if (spriteRenderer.sprite.name == "Blue_Idle_0" 
        || spriteRenderer.sprite.name == "Blue_Idle_1" 
        || spriteRenderer.sprite.name == "Blue_Idle_2"
        || spriteRenderer.sprite.name == "Blue_Idle_3"
        || spriteRenderer.sprite.name == "Blue_Idle_4"
        || spriteRenderer.sprite.name == "Blue_Idle_5")      
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture);
        }

        if (spriteRenderer.sprite.name == "Blue_Run_0_South_0"
        || spriteRenderer.sprite.name == "Blue_Run_0_South_1"
        || spriteRenderer.sprite.name == "Blue_Run_0_South_2"
        || spriteRenderer.sprite.name == "Blue_Run_0_South_3"
        || spriteRenderer.sprite.name == "Blue_Run_0_South_4"
        || spriteRenderer.sprite.name == "Blue_Run_0_South_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_00);
        }

        if (spriteRenderer.sprite.name == "Blue_Run_2_East_0"
        || spriteRenderer.sprite.name == "Blue_Run_2_East_1"
        || spriteRenderer.sprite.name == "Blue_Run_2_East_2"
        || spriteRenderer.sprite.name == "Blue_Run_2_East_3"
        || spriteRenderer.sprite.name == "Blue_Run_2_East_4"
        || spriteRenderer.sprite.name == "Blue_Run_2_East_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_02);
        }

        if (spriteRenderer.sprite.name == "Blue_Run_4_North_0"
        || spriteRenderer.sprite.name == "Blue_Run_4_North_1"
        || spriteRenderer.sprite.name == "Blue_Run_4_North_2"
        || spriteRenderer.sprite.name == "Blue_Run_4_North_3"
        || spriteRenderer.sprite.name == "Blue_Run_4_North_4"
        || spriteRenderer.sprite.name == "Blue_Run_4_North_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_04);
        }

        if (spriteRenderer.sprite.name == "Blue_Run_6_West_0"
        || spriteRenderer.sprite.name == "Blue_Run_6_West_1"
        || spriteRenderer.sprite.name == "Blue_Run_6_West_2"
        || spriteRenderer.sprite.name == "Blue_Run_6_West_3"
        || spriteRenderer.sprite.name == "Blue_Run_6_West_4"
        || spriteRenderer.sprite.name == "Blue_Run_6_West_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_06);
        }

        // Rolling

        if (spriteRenderer.sprite.name == "Blue_Roll_0_0"
        || spriteRenderer.sprite.name == "Blue_Roll_0_1"
        || spriteRenderer.sprite.name == "Blue_Roll_0_2"
        || spriteRenderer.sprite.name == "Blue_Roll_0_3")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Roll_00);
        }

        if (spriteRenderer.sprite.name == "Blue_Roll_2_0"
        || spriteRenderer.sprite.name == "Blue_Roll_2_1"
        || spriteRenderer.sprite.name == "Blue_Roll_2_2"
        || spriteRenderer.sprite.name == "Blue_Roll_2_3")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Roll_02);
        }

        if (spriteRenderer.sprite.name == "Blue_Roll_4_0"
        || spriteRenderer.sprite.name == "Blue_Roll_4_1"
        || spriteRenderer.sprite.name == "Blue_Roll_4_2"
        || spriteRenderer.sprite.name == "Blue_Roll_4_3")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Roll_04);
        }

        if (spriteRenderer.sprite.name == "Blue_Roll_6_0"
        || spriteRenderer.sprite.name == "Blue_Roll_6_1"
        || spriteRenderer.sprite.name == "Blue_Roll_6_2"
        || spriteRenderer.sprite.name == "Blue_Roll_6_3")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Roll_06);
        }


        // Firing Laser Idles

        if (spriteRenderer.sprite.name == "Blue_Laser_Idle_0_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_0_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_0_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_0_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_0_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_0_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Idle_0);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Idle_1_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_1_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_1_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_1_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_1_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_1_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Idle_1);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Idle_2_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_2_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_2_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_2_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_2_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_2_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Idle_2);
        }
        
        if (spriteRenderer.sprite.name == "Blue_Laser_Idle_3_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_3_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_3_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_3_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_3_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_3_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Idle_3);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Idle_4_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_4_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_4_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_4_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_4_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_4_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Idle_4);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Idle_5_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_5_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_5_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_5_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_5_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_5_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Idle_5);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Idle_6_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_6_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_6_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_6_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_6_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_6_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Idle_6);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Idle_7_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_7_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_7_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_7_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_7_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Idle_7_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Idle_7);
        }

        // Firing Laser Running
        
        if (spriteRenderer.sprite.name == "Blue_Laser_Run_0_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_0_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_0_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_0_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_0_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_0_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Run_0);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Run_1_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_1_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_1_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_1_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_1_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_1_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Run_1);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Run_2_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_2_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_2_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_2_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_2_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_2_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Run_2);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Run_3_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_3_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_3_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_3_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_3_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_3_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Run_3);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Run_4_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_4_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_4_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_4_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_4_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_4_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Run_4);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Run_5_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_5_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_5_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_5_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_5_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_5_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Run_5);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Run_6_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_6_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_6_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_6_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_6_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_6_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Run_6);
        }

        if (spriteRenderer.sprite.name == "Blue_Laser_Run_7_0"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_7_1"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_7_2"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_7_3"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_7_4"
        || spriteRenderer.sprite.name == "Blue_Laser_Run_7_5")
        {
            spriteRenderer.material.SetTexture("_EmissionMap", EmissionMapTexture_Fire_Run_7);
        }
    }
}
