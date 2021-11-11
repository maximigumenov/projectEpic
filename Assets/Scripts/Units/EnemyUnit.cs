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
            Initialization();
        }

        private void Update()
        {
            UpdateUnit();
        }

        public override void Initialization()
        {
            base.Initialization();
            switch (enemyType)
            {
                case EnemyType.Sleep:
                    break;
                case EnemyType.Patrolling:
                    targetPatrol.Shuffle();
                    Next();
                    break;
                default:
                    break;
            }
        }

        public override void UpdateUnit()
        {
            base.UpdateUnit();
            switch (enemyType)
            {
                case EnemyType.Sleep:
                    MoveWait();
                    break;
                case EnemyType.Patrolling:
                    CheckDistance();
                    MoveForvard();
                    transform.LookAtTarget(current);
                    break;
                default:
                    break;
            }
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
