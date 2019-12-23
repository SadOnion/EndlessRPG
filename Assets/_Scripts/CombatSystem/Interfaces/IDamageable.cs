using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int amount,DamageType damageType);
}
public enum DamageType
{
    None
}
