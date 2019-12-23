using CombatSystem.Stats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Ability",menuName ="Ability/Projectiles")]
public class Projectiles : Ability
{
    public override void Use(Transform spawnPoint,PlayerStats stats)
    {
         GameObject o = Instantiate(objectsToSpawn[0],spawnPoint.position,objectsToSpawn[0].transform.rotation);
            
    }
}
