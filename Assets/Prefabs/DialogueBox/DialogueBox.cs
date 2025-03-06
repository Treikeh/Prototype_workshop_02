using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class DialogueBox : MonoBehaviour
{
    [SerializeField] private List<DialogueDialogue> dialogue;
    [SerializeField] private TMP_Text dialogueName;
    [SerializeField] private TMP_Text dialogueText;
    private int currentDialogue = 0;

    public UnityEvent dialogueBoxOpened;
    public UnityEvent dialogueBoxClosed;
    public UnityEvent finalDialogueReached;


    void Start()
    {
        dialogueName.text = dialogue[currentDialogue].speakerName;
        dialogueText.text = dialogue[currentDialogue].dialogue;
    }


    public void OpenDialogueBox()
    {
        gameObject.SetActive(true);
        dialogueBoxOpened.Invoke();
    }

    public void CloseDialogueBox()
    {
        gameObject.SetActive(false);
        dialogueBoxClosed.Invoke();
    }


    public void NextDialogueText()
    {
        if (currentDialogue == (dialogue.Count - 1))
        {
            return;
        }
        
        currentDialogue += 1;
        dialogueName.text = dialogue[currentDialogue].speakerName;
        dialogueText.text = dialogue[currentDialogue].dialogue;

        if (currentDialogue == (dialogue.Count - 1))
        {
            finalDialogueReached.Invoke();
        }
    }
}


[Serializable]
public class DialogueDialogue
{
    public String speakerName;
    public String dialogue;
}