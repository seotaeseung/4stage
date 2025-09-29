using TMPro;
using UnityEngine;

public class DialogueUI : MonoBehaviour
{
    public GameObject dialoguePanel;      // 대화창 패널
    public TextMeshProUGUI nameText;      // 이름 텍스트
    public TextMeshProUGUI sentenceText;  // 문장 텍스트
    public void ShowPanel(bool active)
    {
        dialoguePanel.SetActive(active);
    }
    public void SetName(string name)
    {
        nameText.text = name;
    }

    public void SetSentence(string sentence)
    {
        sentenceText.text = sentence;
    }
}
