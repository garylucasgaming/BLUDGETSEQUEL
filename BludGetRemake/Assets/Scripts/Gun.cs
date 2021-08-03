using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Gun : ScriptableObject
{

    public float fireRate;
    public int damage;
    public int range;
    public bool isHitscan;
    public bool isRapidFire;
    public GameObject gunPrefab;
    public GameObject projectilePrefab;



    public virtual void OnFire( Transform projectileSpawn)
    {

    }

    public virtual void EndFire()
    {

    }

    

}
