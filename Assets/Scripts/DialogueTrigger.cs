using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject interactPanel;
    public GameObject dialogueBox;
    public PlayerInput playerInput;
    public PlayerAimWeapon aimWeapon;

    public void Awake()
    {
        interactPanel.SetActive(false);
        dialogueBox.SetActive(false);
    }

    public void TriggerDialogue()
    {
        dialogueBox.SetActive(true);
        interactPanel.SetActive(false);
        dialogueBox.GetComponent<DialogueBox>().GetScript();

        // Disable player input
        playerInput.DeactivateInput();
        if (aimWeapon != null)
        {
            aimWeapon.ToggleInputHandling(false);
        }
    }

    public void EndDialogue()
    {
        playerInput.ActivateInput();
        aimWeapon.ToggleInputHandling(true);
    }

    public bool IsDialogueActive()
    {
        bool active = dialogueBox.activeSelf;
        return active;
    }
}