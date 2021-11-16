using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestWin : BaseQuest
{
    public ScriptableWinQuest data;


    private bool isShow;
    private bool isNext;

    public void CallWin() {
        QuestManager.Call(questID, type);
    }

    public override void JobQuest(int id, TypeQuest _type)
    {
        if (_type == type)
        {
            base.JobQuest(id, _type);
            ScriptableWinQuest.ScriptableWinQuestData result = data.GetData(id);
            if (result.type == ScriptableWinQuest.TypeNext.NextScene)
            {
                SceneManager.LoadScene(result.nextScene);
            }
        }
    }
}
