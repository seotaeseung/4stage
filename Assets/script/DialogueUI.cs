using TMPro;
using UnityEngine;

public class DialogueUI : MonoBehaviour
{
    public GameObject dialoguePanel;      // ��ȭâ �г�
    public TextMeshProUGUI nameText;      // �̸� �ؽ�Ʈ
    public TextMeshProUGUI sentenceText;  // ���� �ؽ�Ʈ
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
