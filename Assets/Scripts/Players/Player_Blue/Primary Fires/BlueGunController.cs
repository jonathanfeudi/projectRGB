using UnityEngine;

using System.Collections;

public class BlueGunController : MonoBehaviour
{
    [Header("Initialized Variables")]

    // Player Controller
    private BluePlayerController bluePlayerController;

    // Laser Trigger
    public bool isFiringLaser;

    public bool altFire;

    // Blues Fire Point Origin
    public Transform firePoint;

    // Blues Fire Point Origin
    public Transform barrierDeployPoint;

    [Header("Laser Variables")]

    public int damageOverTime = 10;

    // SFX
    public AudioSource sfx_AudioSource;
    public AudioClip sfx_BlueLaserCollide;

    private bool laserCollider = false;

    // Orbs // NOT USED // SAVE FOR TURRET...???what
    public BlueBulletController bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public bool canShoot = true;

    public Transform target; // Enemy Point Origin 

     // Laser Rendering and Particle Effects
    public LineRenderer lineRenderer; // Line Render

    // Laser Reset Point
    public Transform laserResetPoint2bats;
    public Transform laserResetPoint1bats;
    public Transform laserResetPoint0bats;

    private float maxDistance;

    public ParticleSystem impactEffect; // Particle System

    public Light impactLight;
    //public Light handLight;

    // Blue Barrier
    public BlueBarrierController barrier;
    public int barrierCounter;

    public bool holdingBarrier;
    public bool deployBarrier;

    // Blue Turret
    public BlueTurretController turret;
    public bool holdingTurret;
    public bool deployTurret;

    //======================================

    // Start is called before the first frame update (Create Event?)
    void Start()
    {

        altFire = false;

        canShoot = true;

        // Player Controller
        bluePlayerController = GetComponent<BluePlayerController>();

        sfx_AudioSource = GetComponent<AudioSource>();

        // Audio Sources
    }

    //======================================

    // USE Primary Fire //

    // Laser Effects

    void Update() // Laser Effects and Alt Fire   // Update is called once per frame
    {
        // Max Laser Distance Raycast Var
        // 2Bats = Full
        if (barrierCounter == 0)
        {
            maxDistance = 12;
        }

        // 1Bat = 1/2
        if (barrierCounter == 1)
        {
            maxDistance = 9;
        }

        // 0Bats = 0...duh
        if (barrierCounter == 2)
        {
            maxDistance = 7;
        }

        //======================================

        if (isFiringLaser && !altFire)
        {
            // Laser Graphics
            if (!lineRenderer.enabled)
            {
                lineRenderer.enabled = true;
                impactEffect.Play(); // Particles
                impactLight.enabled = true; // Light
                sfx_AudioSource.Play();
                //handLight.enabled = true;
            }

            //lineRenderer.SetPosition(0, firePoint.position);
            //lineRenderer.SetPosition(1, transform.forward * 10 + transform.position); // Max Distance

            // Rotate Direcion Particles Face
            Vector3 dir = firePoint.position - transform.forward * 10 + transform.position;  // Vector with direction facing Player
            impactEffect.transform.rotation = Quaternion.LookRotation(dir); // Rotate Particle Collide                       
        }
        else // Turn Off Laser and Effects
        {
            lineRenderer.enabled = false;
            impactEffect.Stop(); // Particles
            impactLight.enabled = false; // Particle Lighting 
            sfx_AudioSource.Stop(); // Stop Audio

            laserCollider = false;

            //handLight.enabled = false; // Lighting Effects Hands
        }

        //======================================

        // ALTERNATE FIRE
        if (isFiringLaser && altFire) // Charge Shot Alt 
        {           
            if (canShoot == true)
            {
                BlueBulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BlueBulletController;

                canShoot = false;
            }                   
        }

        //======================================

        // USE ABILITIES //

        // Barrier
        if (holdingBarrier && barrierCounter < 2) // Charge Shot Alt 
        {
            BlueBarrierController newBarrier = Instantiate(barrier, barrierDeployPoint.position, barrierDeployPoint.rotation) as BlueBarrierController;

            holdingBarrier = false;

            barrierCounter += 1;
        }

        // Turret
        if (holdingTurret && barrierCounter < 2) // Charge Shot Alt 
        {
            BlueTurretController newTurret = Instantiate(turret, barrierDeployPoint.position, barrierDeployPoint.rotation) as BlueTurretController;

            holdingTurret = false;

            barrierCounter += 1;
        }
    }

    //======================================

    void LateUpdate() // Laser // THIS IS WHERE TO FIX THE LIGHT REMAINING WHEN NOT SHOOTING
    {
        if (!altFire)
        {
            // Laser Raycast Collision
            lineRenderer.SetPosition(0, firePoint.position);
            RaycastHit hit;
            if (Physics.Raycast(firePoint.position, transform.forward, out hit, maxDistance)) /////////////////// 12 is max distance  ********************MAKE SEPERATE RAYCAST FOR EACH BARRIER AMOUNT CONDITION
            {
                //laserCollider = false;

                if (hit.collider)
                {
                    lineRenderer.SetPosition(1, hit.point);
                    impactEffect.transform.position = hit.point; // Particle Collision Location of End of Laser
                    //laserCollider = true;

                    if (laserCollider == false & isFiringLaser) 
                    {
                        AudioSource.PlayClipAtPoint(sfx_BlueLaserCollide, hit.point);
                        laserCollider = true;
                    }
                }

                // Laser Damage Enemy
                if (hit.collider.tag == "Enemy")
                {
                    //Debug.Log(hit.collider.tag);

                    if (isFiringLaser)
                    {
                       hit.collider.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageOverTime * Time.deltaTime, 0);
                    }
                }
            }
            else
            {
                // 2Bats = Full
                if (barrierCounter == 0)
                {
                    impactEffect.transform.position = laserResetPoint2bats.transform.position;
                }

                // 1Bat = 1/2
                if (barrierCounter == 1)
                {
                    impactEffect.transform.position = laserResetPoint1bats.transform.position;
                }

                // 0Bats = 0...duh
                if (barrierCounter == 2)
                {
                    impactEffect.transform.position = laserResetPoint0bats.transform.position;
                }

                lineRenderer.SetPosition(1, impactEffect.transform.position);
            }
        }
    }
}

