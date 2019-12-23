using CombatSystem.Stats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStats playerStats {get;private set;}

    private void Start()
    {
        playerStats = new PlayerStats();
    }

}
