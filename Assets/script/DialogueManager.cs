using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;

    public DialogueUI dialogueUI;

    private DialogueData database;
    private Queue<string> sentences;
    private Dialogue currentDialogue;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        sentences = new Queue<string>();
        database = new DialogueData("Dialogues/text");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dialogueUI.dialoguePanel.activeInHierarchy)
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(string npcId)
    {
        currentDialogue = database.GetDialogue(npcId);

        if (currentDialogue == null) return;

        dialogueUI.ShowPanel(true);
        dialogueUI.SetName(currentDialogue.name);

        sentences.Clear();
        foreach (var sentence in currentDialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    private void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueUI.SetSentence(sentence);
    }
    private void EndDialogue()
    {
        dialogueUI.ShowPanel(false);
    }
}