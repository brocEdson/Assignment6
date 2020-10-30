/* Broc Edson
 * Assignment 6
 * Uses inheritance from the enemy class to generate its methods
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;
    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;
        weapon.damageBonus = 10;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem attacks");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("Golem took " + amount + " damage");
    }
}
