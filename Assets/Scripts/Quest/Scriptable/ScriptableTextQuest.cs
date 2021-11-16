using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TextQuest", menuName = "ScriptableObjects/TextQuest", order = 1)]
public class ScriptableTextQuest : ScriptableObject
{
    public List<ScriptableTextQuestData> data;

    public bool Text(int id, out ScriptableTextQuestData questData) {
        questData = null;
        ScriptableTextQuestData result = data.Find(x => x.id == id);

        if (result == null)
        {
            return false;
        }

        questData = result;

        return true;
    }

    [System.Serializable]
    public class ScriptableTextQuestData {
        public int id;
        public string data;
        public bool isNext;
        public int nextID;
    }
}
