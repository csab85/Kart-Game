using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class StartKart : MonoBehaviour
{

    [SerializeField] GameObject[] karts;
    [SerializeField] CinemachineVirtualCamera cam;

    int selectedNum;

    // Start is called before the first frame update
    void Start()
    {
        selectedNum = Mathf.RoundToInt(KartSelect.selectedKartNumber);

        cam.Follow = karts[selectedNum].transform;
        cam.LookAt = karts[selectedNum].transform;
        karts[selectedNum].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
