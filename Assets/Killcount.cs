using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{
[SerializeField]
private int killCount = 0;
[SerializeField]
private Text killCountText;


void Start()
{
    // Hämta referens till Textobjektet
    killCountText = GetComponent<Text>();
    UpdateKillCountText();
}

// Uppdatera killcountet och texten på skärmen
void UpdateKillCountText()
{
    killCountText.text = "Kill Count: " + killCount.ToString();
}

// Öka killcountet när en fiende dödas
public void IncreaseKillCount()
{
    killCount++;
    UpdateKillCountText();
}
}
