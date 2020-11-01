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
    private Vector3 target;
    private Vector3 initialPos;

    private void Awake()
    {
        timer = moveTime;
        movingTowardsMax = true;
        initialPos = transform.position;
        target = new Vector3(initialPos.x, maxY + initialPos.y, maxZ + initialPos.z);
    }

    void Update()
    {
        Vector3.Lerp(transform.position, target, moveTime);
        if (timer >= Time.time)
        {
            timer = Time.time + moveTime;
            movingTowardsMax = !movingTowardsMax;
            if(movingTowardsMax)
            {
                target = new Vector3(transform.position.x, maxY + initialPos.y, maxZ + initialPos.y);
            }
            else
            {
                target = new Vector3(transform.position.x, minY + initialPos.y, minZ + initialPos.y);
            }
        }
    }
}
