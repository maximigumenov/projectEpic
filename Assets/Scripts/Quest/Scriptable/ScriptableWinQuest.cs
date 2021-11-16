using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WinQuest", menuName = "ScriptableObjects/WinQuest", order = 2)]
public class ScriptableWinQuest : ScriptableObject
{
    public List<ScriptableWinQuestData> data;

    public ScriptableWinQuestData GetData(int id)
    {
        return data.Find(x => x.id == id);
    }

    [System.Serializable]
    public class ScriptableWinQuestData
    {
        public int id;
        public TypeNext type;
        public string nextScene;
    }

    public enum TypeNext { 
        None,
        NextScene
    }
}
