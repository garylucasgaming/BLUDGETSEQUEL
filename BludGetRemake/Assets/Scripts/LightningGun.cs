using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class LightningGun : Gun
{

    GameObject projectile;

    public override void OnFire( Transform projectileSpawn)
    {
         projectile = Instantiate(projectilePrefab, projectileSpawn.position, projectileSpawn.rotation, projectileSpawn);
        
    }

    public override void EndFire()
    {
        Destroy(projectile, .15f);
    }


   


}
