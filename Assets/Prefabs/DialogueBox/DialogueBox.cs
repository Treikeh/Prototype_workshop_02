using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class DialogueBox : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueName;
    [SerializeField] private TMP_Text dialogueText;

    public UnityEvent dialogueBoxOpened;
    public UnityEvent dialogueBoxClosed;


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


    public void UpdateDialogueName(string text)
    {
        dialogueName.text = text;
    }


    public void UpdateDialogueText(string text)
    {
        dialogueText.text = text;
    }

}
