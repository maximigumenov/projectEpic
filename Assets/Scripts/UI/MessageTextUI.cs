using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageTextUI : MonoBehaviour
{
    private static MessageTextUI instance;
    public Text messageUI;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public static void Tip(string message) {
        instance.messageUI.text = message;
    }

    public static void Clear()
    {
        instance.messageUI.text = "";
    }
}
