using UnityEngine;

public class npc : MonoBehaviour
{
    public string npcId;
    private bool isPlayerInRange;
    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.Space) && !DialogueManager.instance.dialogueUI.dialoguePanel.activeInHierarchy)
        {
            DialogueManager.instance.StartDialogue(npcId);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PLAYER"))
        {
            isPlayerInRange = true; // �÷��̾ ���Դٰ� ǥ��
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("PLAYER"))
        {
            isPlayerInRange = false; // �÷��̾ �����ٰ� ǥ��
        }
    }
}
