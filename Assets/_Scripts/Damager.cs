using CombatSystem.Stats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    public Ability ability;
    [SerializeField] PlayerStats stats;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();
        Debug.Log(damageable);
        damageable?.TakeDamage(ability.damage,DamageType.None);
    }
}
