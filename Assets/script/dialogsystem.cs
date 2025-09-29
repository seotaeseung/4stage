using UnityEngine;
using System.Collections.Generic;
[System.Serializable]
public class Dialogue
{
    public string npcId;
    public string name;
    public List<string> sentences;
}
[System.Serializable]
public class Dialoguecollection
{
    public List<Dialogue> conversations;
}
