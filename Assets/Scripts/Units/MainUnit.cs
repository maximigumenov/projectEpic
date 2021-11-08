﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mockup
{
    public class MainUnit : Unit
    {
        private static MainUnit instance;
        private InputData inputData = new InputData();
        public List<MeshRenderer> meshRenderer;
        private static bool isBlock;

        private void Start()
        {
            instance = this;
        }

        private void Update()
        {
            UpdateInput();
        }

        private void UpdateInput() {
            if (isBlock)
            {
                return;
            }

            isRun = inputData.Shift;
            MoveWait();
            if (inputData.Left)
            {
                MoveLeft();
            }
            if (inputData.Right)
            {
                MoveRight();
            }
            if (inputData.Up)
            {
                MoveForvard();
            }
            if (inputData.Down)
            {
                MoveBack();
            }
        }

        public static float GetDistance(Transform target) {
            return Vector3.Distance(instance.transform.position, target.position);
        }

        public static void HideUnit()
        {
            isBlock = true;
            foreach (var item in instance.meshRenderer)
            {
                item.enabled = false;
            }
            
        }

        public static void ShowUnit()
        {
            isBlock = false;
            foreach (var item in instance.meshRenderer)
            {
                item.enabled = true;
            }
            instance.SetCamera();
        }

    }
}