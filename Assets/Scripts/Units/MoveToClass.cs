using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveToClass
{
    Transform main;
    Transform current;
    List<Transform> targets;
    int currentNum = 0;
    float distance = 0f;
    float speed = 10;
    public Action OnFinish;
    public MoveToClass(Transform main, List<Transform> targets, float speed = 10)
    {
        this.main = main;
        this.targets = targets;
        this.speed = speed;
        currentNum = 0;
        Next();
    }

    private void Next()
    {
        current = targets[currentNum];
        currentNum++;
        if (currentNum >= targets.Count)
        {
            currentNum = 0;
            current = null;
            OnFinish?.Invoke();
        }
    }

    public void Update() {
        
        if (current)
        {
            CheckDistance();
            main.MoveToTarget(current, speed);
        }
       
    }

    private void CheckDistance()
    {
        if (Vector3.Distance(main.position, current.position) <= distance)
        {
            Next();
        }
    }

}
