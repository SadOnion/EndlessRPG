using CombatSystem.Stats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Ability",menuName ="Ability/Slash")]
public class Slash : Ability
{

    public override void Use(Transform spawnPoint,PlayerStats stats)
    {
        GameObject o = Instantiate(objectsToSpawn[0],spawnPoint.position,Quaternion.Euler(0,0,spawnPoint.rotation.eulerAngles.z+30));
        
    }
}