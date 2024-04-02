using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class StartKart : MonoBehaviour
{

    [SerializeField] public GameObject[] karts;
    [SerializeField] CinemachineVirtualCamera[] cams;
    [SerializeField] DetectPower[] detectPowerScripts;

    int selectedNum1;
    int selectedNum2;

    // Start is called before the first frame update
    void Start()
    {
        selectedNum1 = Mathf.RoundToInt(SelectKart.selectedKartNumber1);

        cams[0].Follow = karts[selectedNum1].transform;
        cams[0].LookAt = karts[selectedNum1].transform;
        detectPowerScripts[0].kartPowerScript = karts[selectedNum1].GetComponent<KartPowers>();
        karts[selectedNum1].SetActive(true);
        karts[selectedNum1].GetComponent<KartControl>().playerNumber = 1;

        selectedNum2 = Mathf.RoundToInt(SelectKart.selectedKartNumber2);

        cams[1].Follow = karts[selectedNum2].transform;
        cams[1].LookAt = karts[selectedNum2].transform;
        detectPowerScripts[1].kartPowerScript = karts[selectedNum2].GetComponent<KartPowers>();
        karts[selectedNum2].SetActive(true);
        karts[selectedNum2].GetComponent<KartControl>().playerNumber = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
