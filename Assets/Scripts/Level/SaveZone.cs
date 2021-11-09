using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Mockup
{
    public class SaveZone : EventZone
    {
        private void Update()
        {
            ShowMark();
            EventController();
        }

        private void EventController() {
            if (isCanActive && inputData.Action)
            {
                if (!isActive)
                {
                    isActive = true;
                    activeEvent?.Invoke();
                }
                else
                {
                    isActive = false;
                    deactiveEvent?.Invoke();
                }
            }
        }
    }
}
