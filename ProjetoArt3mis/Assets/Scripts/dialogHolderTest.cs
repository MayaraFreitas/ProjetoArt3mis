using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogHolderTest : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dMan;

    public string[] dialogLines;

    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKey(KeyCode.W))
            {
                //dMan.ShowBox(dialogue);
                if (!dMan.dialogActive)
                {
                    dMan.dialogueLines = dialogLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                    dMan.dialogActive = false;
                }

                if (transform.parent.GetComponent<VillagerMovement>() != null)
                {
                    transform.parent.GetComponent<VillagerMovement>().canMove = false;
                }
            }
        }
    }
}
