using CombatSystem.Stats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityHandler : MonoBehaviour
{ 
    
    [SerializeField]private Ability ability=null;
    [SerializeField]private Transform spawnPoint;
    private PlayerStats playerStats;
    float timer;
    private void Start()
    {
        timer = ability.fireRate;
        playerStats = GetComponent<Player>().playerStats;
    }
    private void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            if (timer <= 0)
            {
            UseAbility();
                timer = ability.fireRate;
            }
        }
        timer-=Time.deltaTime;
    }
    public void UseAbility()
    {
        ability.Use(spawnPoint,playerStats);
    }
}

