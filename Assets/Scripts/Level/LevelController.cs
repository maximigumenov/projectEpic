using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mockup
{
    public class LevelController : MonoBehaviour
    {
        private InputData inputData = new InputData();
        [SerializeField]
        private MainUnit mainUnit;
        public bool showQuest;
        
        // Start is called before the first frame update
        void Start()
        {
            Initialization();
            if (showQuest)
            {
                QuestManager.Call(1, TypeQuest.Text);
            }
            
        }

        // Update is called once per frame
        void Update()
        {
            if (inputData.Exit)
            {
                Application.Quit();
            }
        }

        private void Initialization()
        {
            mainUnit.SetCamera();
        }

    }
}
