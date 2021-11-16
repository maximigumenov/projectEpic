using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mockup
{
    public class CrouchZone : EventZone
    {

        private void Start()
        {
            StartCoroutine(EventController());
        }

        private void Update()
        {
            ShowMark();
            //EventController();
        }

        IEnumerator EventController() {
            yield return new WaitForSeconds(0.2f);
            if (isCanActive && isCurrentActive)
            {
                MainUnit.instance.isCrouch = true;
            }
            StartCoroutine(EventController());
        }

        /*private void EventController()
        {
            if (isCanActive)
            {
                Debug.LogError("CrouchZone");
            }
        }*/
    }
}
