using UnityEngine;

public class QuestItem : MonoBehaviour
{
    public int questNumber;
    public string itemName;

    private QuestManager theQM;

    void Start()
    {
        theQM = FindObjectOfType<QuestManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (!theQM.questCompleted[questNumber] && theQM.quests[questNumber].gameObject.activeSelf)
            {
                theQM.itemCollected = itemName;
                gameObject.SetActive(false);
            }
        }
    }
}
