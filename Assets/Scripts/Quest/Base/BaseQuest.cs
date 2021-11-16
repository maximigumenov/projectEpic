using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseQuest : MonoBehaviour
{
    public int questID = -1;
    public TypeQuest type;
    // Start is called before the first frame update
    void Awake()
    {
        QuestManager.Call += JobQuest;
        QuestManager.Done += OnDone;
    }

    private void OnDestroy()
    {
        QuestManager.Call -= JobQuest;
        QuestManager.Done -= OnDone;
    }

    public virtual void JobQuest(int id, TypeQuest _type) { 
    
    }

    public virtual void OnDone(int id, TypeQuest _type)
    {

    }

    public virtual void Done()
    {
        QuestManager.Call?.Invoke(questID, type);
    }

    public virtual void Done(int id, TypeQuest _type)
    {
        QuestManager.Call?.Invoke(id, _type);
    }
}
