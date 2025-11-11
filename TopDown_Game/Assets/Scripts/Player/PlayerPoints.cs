using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;  
    [SerializeField] private PlayerController player;

    private void Update()
    {
        if (player != null)
        {
            pointsText.text = "Puntos: " + player.upgradePoints.ToString();
        }
    }
}