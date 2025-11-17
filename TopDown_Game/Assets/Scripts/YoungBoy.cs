using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class YoungBoy : MonoBehaviour
{
    [TextArea(3, 6)]
    [SerializeField] private string[] dialogueLines;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;

    [SerializeField] private int requiredXP = 5; 
    [SerializeField] private int healthIncreaseAmount = 1;

    private int currentLine = 0;
    private bool dialogueActive = false;
    private bool playerInRange = false;

    private PlayerController player;

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!dialogueActive)
            {
                StartDialogue();
            }
            else
            {
                DisplayNextLine();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
            player = collision.GetComponent<PlayerController>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
            if (dialogueActive)
                EndDialogue();
        }
    }

    private void StartDialogue()
    {
        currentLine = 0;
        dialogueActive = true;
        dialoguePanel.SetActive(true);

        if (dialogueLines.Length > 0)
        {
            dialogueText.text = dialogueLines[currentLine];
        }
        else
        {
            Debug.LogWarning("El NPC no tiene líneas de diálogo asignadas.");
            EndDialogue();
        }
    }

    private void DisplayNextLine()
    {
        currentLine++;

        if (currentLine < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentLine];
        }
        else
        {
            // Cuando termina el diálogo, se realiza la mejora si el jugador tiene XP suficiente
            TryUpgradePlayer();
            EndDialogue();
        }
    }

    private void TryUpgradePlayer()
    {
        if (player == null) return;

        if (player.upgradePoints >= requiredXP)
        {
            player.upgradePoints -= requiredXP;
            player.IncreaseMaxHealth(healthIncreaseAmount);
            
            
        }
        
    }
    private void EndDialogue()
    {
        dialogueActive = false;
        dialoguePanel.SetActive(false);
        currentLine = 0;
    }
}