using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    private QuestManager theQM;
    private Inventory inventory;

    public int questNumber;
    public bool startQuest;
    public bool endQuest;

    void Start()
    {
        theQM = FindObjectOfType<QuestManager>();
        inventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            // Se a quest ainda estiver em aberto e se exigir uma missão anterior, ela deve estar cumprida
            if (!theQM.questCompleted[questNumber] &&
                (theQM.quests[questNumber].questNumber == 0 || theQM.questCompleted[theQM.quests[questNumber].previousMission]))
            {
                if (startQuest && !theQM.quests[questNumber].gameObject.activeSelf)
                {
                    theQM.quests[questNumber].gameObject.SetActive(true);
                    theQM.quests[questNumber].StartQuest();
                }
                else if (endQuest && theQM.quests[questNumber].gameObject.activeSelf)
                {
                    // Para terminar quests com item, é preciso que ele esteja no inventário
                    if (theQM.quests[questNumber].isItemQuest && !inventory.HaveAItem(theQM.quests[questNumber].targetItem))
                    {
                        theQM.quests[questNumber].ShowMiddleText();
                    }
                    else
                    {
                        theQM.quests[questNumber].EndQuest();
                    }
                }
                else
                {
                     theQM.quests[questNumber].ShowMiddleText();
                }
            }
        }
    }
}
