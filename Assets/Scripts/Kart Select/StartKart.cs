using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartKart : MonoBehaviour
{

    [SerializeField] GameObject[] karts;

    int selectedNum;

    // Start is called before the first frame update
    void Start()
    {
        selectedNum = Mathf.RoundToInt(KartSelect.selectedKartNumber);

        karts[selectedNum].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        print(KartSelect.selectedKartNumber);
    }
}
