/* Broc Edson
 * Assignment 6
 * Provides abstract implementation of a target
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IDamageable
{
    protected int health;
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        health = 10;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log(health);
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
