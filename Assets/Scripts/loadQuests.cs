using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadQuests : MonoBehaviour
{
    List<Quest> quests = new List<Quest>();

    void Start()
    {
        TextAsset questdata = Resources.Load<TextAsset>("infodata");

        string[] data = questdata.text.Split(new char[] { '\n' });

        for (int i = 1; i < data.Length - 1; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });

            if (row[1] != "")
            {
                Quest q = new Quest();
                int.TryParse(row[0], out q.id);
                q.name = row[1];
                int.TryParse(row[2], out q.count);
                int.TryParse(row[3], out q.price);

                quests.Add(q);
            }
        }

        foreach (Quest q in quests)
        {
            Debug.Log(q.id);
        }
    }

    void Update()
    {
        
    }
}
