using UnityEngine;

public class DialogueData 
{
    private Dialoguecollection dialogueCollection;

    public DialogueData(string path)
    {
        TextAsset jsonFile = Resources.Load<TextAsset>(path);
        dialogueCollection = JsonUtility.FromJson<Dialoguecollection>(jsonFile.text);
    }

    public Dialogue GetDialogue(string npcId)
    {
        return dialogueCollection.conversations.Find(d => d.npcId == npcId);
    }
}
