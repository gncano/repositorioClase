using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OldMan : MonoBehaviour
{
    [TextArea(3, 6)]
    [SerializeField] private string[] dialogueLines;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;

    private int currentLine = 0;
    private bool dialogueActive = false;
    private bool playerInRange = false; 

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
            EndDialogue();
        }
    }


    private void EndDialogue()
    {
        dialogueActive = false;
        dialoguePanel.SetActive(false);
        currentLine = 0;
    }
}
