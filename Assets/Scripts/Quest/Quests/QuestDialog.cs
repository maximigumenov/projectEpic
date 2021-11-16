using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mockup;

public class QuestDialog : BaseQuest
{
    private InputData inputData = new InputData();
    public ScriptableTextQuest data;
    [Space]
    public GameObject mainObject;
    public Text mainText;


    private bool isShow;
    private bool isNext;

    public override void JobQuest(int id, TypeQuest _type)
    {
        if (_type == type)
        {
            base.JobQuest(id, _type);
            ScriptableTextQuest.ScriptableTextQuestData result;
            if (data.Text(id, out result))
            {
                MainUnit.BlockUnit();
                isShow = true;
                questID = result.nextID;
                isNext = result.isNext;
                mainObject.SetActive(true);
                mainText.text = result.data;
            }
        }
    }

    public override void Done()
    {
        isShow = false;
        mainObject.SetActive(false);
        mainText.text = "";
        base.Done();
    }


    private void Update()
    {
        if (isShow && inputData.SpacePress && isNext)
        {
            Done();
        }
        else if (isShow && inputData.SpacePress)
        {
            isShow = false;
            mainObject.SetActive(false);
            mainText.text = "";
            MainUnit.ShowUnit();
        }
    }
}
