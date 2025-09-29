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
            isPlayerInRange = true; // 플레이어가 들어왔다고 표시
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("PLAYER"))
        {
            isPlayerInRange = false; // 플레이어가 나갔다고 표시
        }
    }
}
