using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mockup
{
    public class EnemyUnit : Unit
    {
        public EnemyType enemyType;
        [Space]
        public List<Transform> targetPatrol;
        private Transform current;
        private int currentNum = 0;

        private float minDistance = 2;

        private void Start()
        {
            targetPatrol.Shuffle();
            Next();
        }

        private void Update()
        {
            CheckDistance();
            MoveForvard();
            transform.LookAtTarget(current);
        }

        private void Next() {
            current = targetPatrol[currentNum];
            currentNum++;
            if (currentNum >= targetPatrol.Count)
            {
                currentNum = 0;
            }
        }

        private void CheckDistance() {
            if (Vector3.Distance(transform.position, current.position) < minDistance)
            {
                Next();
            }
        }

    }
}
