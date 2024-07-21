using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeWait : MonoBehaviour
{
    private const float TickTimerMax = 2f;

    private int tick;
    private float tickTimer;

    private void Awake()
    {
        tick = 0;
    }

    private void Update()
    {
        tickTimer += Time.deltaTime;
        if (tickTimer >= TickTimerMax)
        {
            tickTimer -= TickTimerMax;
            tick++;
            Debug.Log("tick :" + tick);
        }
    }
}
