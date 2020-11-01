/* Broc Edson
 * Assignment 6
 * Provides a target object that can take damage
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IDamageable
{
    protected int health;
    protected UIManager uiMan;

    protected virtual void Awake()
    {
        uiMan = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        health = 10;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log(health);
        if(health <= 0)
        {
            uiMan.targetsRemaining--;
            Destroy(gameObject);
        }
    }
}
