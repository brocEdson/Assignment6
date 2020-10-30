﻿/* Broc Edson
 * Assignment 6
 * Provides abstract implementation of an enemy
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable
{
    protected float speed;
    protected int health;
    [SerializeField] protected Weapon weapon;
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();
        speed = 5f;
        health = 100;
    }

    protected abstract void Attack(int amount);
    public abstract void TakeDamage(int amount);

    // Update is called once per frame
    void Update()
    {
        
    }
}
