using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectPower : MonoBehaviour
{
    public KartPowers kartPowerScript;

    TextMeshProUGUI powerText;
    string powerName;

    void Start()
    {
        powerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        powerName = kartPowerScript.powersDict[kartPowerScript.activePower];
        powerText.text = powerName;
    }
}
