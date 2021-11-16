using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class QuestManager : MonoBehaviour
{
    public static Action<int, TypeQuest> Call;
    public static Action<int, TypeQuest> Done;

    // Start is called before the first frame update
    void Start()
    {
        
    }

}

public enum TypeQuest { 
    None,
    Text,
    Win
}
