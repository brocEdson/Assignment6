/* Broc Edson
 * Assignment 6
 * Provides a target object that can move and take damage
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : Target
{
    public float minZ;
    public float maxZ;
    public float minY;
    public float maxY;
    public float moveTime = 1f;
    private float timer = 0f;
    private bool movingTowardsMax = true;
    private Vector3 currentStartPosition;
    private Vector3 target;
    private Vector3 initialPos;

    private void Start()
    {
        timer = Time.time;
        movingTowardsMax = true;
        initialPos = transform.position;
        currentStartPosition = initialPos;
        target = new Vector3(initialPos.x, maxY + initialPos.y, maxZ + initialPos.z);
    }

    void Update()
    {
        transform.position = Vector3.Lerp(currentStartPosition, target, (Time.time - timer) / moveTime);
        if (Time.time >= timer +  moveTime)
        {
            timer = Time.time;
            movingTowardsMax = !movingTowardsMax;
            currentStartPosition = transform.position;
            if(movingTowardsMax)
            {
                target = new Vector3(initialPos.x, maxY + initialPos.y, maxZ + initialPos.z);
            }
            else
            {
                target = new Vector3(initialPos.x, minY + initialPos.y, minZ + initialPos.z);
            }
        }
    }
}
