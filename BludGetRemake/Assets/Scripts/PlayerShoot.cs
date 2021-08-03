using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public bool isFiring;
    public Gun gun;
    public Transform projectileSpawn;
    public Camera FPSCam;
    private float cooldown;

    private void Start()
    {
        cooldown = Time.time;
    }


    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0) && !isFiring && Time.time - cooldown > gun.fireRate)
        {
            if(!gun.isRapidFire)
            {
                isFiring = true;
            }
            if(!gun.isHitscan)
            {
                gun.OnFire(projectileSpawn);
            }
            else
            {
                RaycastHit hit;
                if(Physics.Raycast(FPSCam.transform.position, FPSCam.transform.forward, out hit, gun.range))
                {
                    
                    Target target = hit.transform.GetComponent<Target>();

                    if(target != null)
                    {
                        target.TakeDamage(gun.damage);
                        Debug.Log(hit.transform.name + ", health: " + target.health);
                    }
                }
            }

            cooldown = Time.time;
           
        }
        if(Input.GetMouseButtonUp(0))
        {
            if(!gun.isRapidFire)
            {
                isFiring = false;
            }
            if(!gun.isHitscan)
            {
                gun.EndFire();
            }
            else
            {
            }
            
        }


    }
}
