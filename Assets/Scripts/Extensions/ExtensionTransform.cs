using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class ExtensionTransform
{
    public static void MoveToTarget(this Transform transform, Transform target, float speed = 100.0f)
    {
        if (target != null && target.gameObject != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    public static void LookAtTarget(this Transform transform, Transform target, float speed = 100.0f)
    {
        if (target != null && target.gameObject != null)
        {
            transform.LookAt(target);
           // transform.LookAt(target);
        }
    }

    private static System.Random rng = new System.Random();

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
