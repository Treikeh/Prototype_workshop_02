using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class DialogueBox : MonoBehaviour
{
    [SerializeField] private List<String> dialogue;
    [SerializeField] private TMP_Text dialogueName;
    [SerializeField] private TMP_Text dialogueText;
    private int currentDialogue = 0;

    public UnityEvent dialogueBoxOpened;
    public UnityEvent dialogueBoxClosed;


    void Start()
    {
        dialogueText.text = dialogue[currentDialogue];
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
        if (currentDialogue >= (dialogue.Count - 1))
        {
            Debug.Log("Final dialogue");
            return;
        }
        currentDialogue += 1;
        dialogueText.text = dialogue[currentDialogue];
    }
}
