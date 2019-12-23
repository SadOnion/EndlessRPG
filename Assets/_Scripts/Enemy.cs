using CombatSystem.Stats;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IDamageable
{
    public int hp;
    Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        MakeDecision();
    }
    private void MakeDecision()
    {
        int rnd = UnityEngine.Random.Range(0,3);
        switch (rnd)
        {
            case 0:
                StartCoroutine(Move(new Vector2(-1,1)));
                break;
            case 1:
                StartCoroutine(Move(Vector2.one));

                break;
            case 2:
                StartCoroutine(Shoot());

                break;
        }
    }

    private IEnumerator Move(Vector2 vec)
    {
        yield return new WaitForSeconds(2f);
        body.AddForce(vec*5,ForceMode2D.Impulse);
        MakeDecision();
    }

    private IEnumerator Shoot()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Atack");
        MakeDecision();
    }

    public void TakeDamage(int amount, DamageType damageType)
    {
        hp-= amount;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("siem");
    }
}
