using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VictoryMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = $"Jogador {EndGame.winnerPlayer.ToString()} venceu!";
    }
}
