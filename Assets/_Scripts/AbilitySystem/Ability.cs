using CombatSystem.Stats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public GameObject[] objectsToSpawn;
    public float fireRate;
    public int damage;
    public abstract void Use(Transform spawnPoint,PlayerStats stats);
}


