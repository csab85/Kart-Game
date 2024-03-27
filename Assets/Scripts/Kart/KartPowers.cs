using KartGame.KartSystems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class KartPowers : MonoBehaviour
{
    [SerializeField] GameObject[] powersObjects;
    [SerializeField] public int activePower;

    [SerializeField]
    public Dictionary<string, float> powersDict = new Dictionary<string, float>()
    {
        {"none", 0},
        {"landmine", 1},
        {"missile", 2},
        {"auto missile", 3},
        {"hourglass", 4},
        {"wormhole", 5}
    };

    public void UsePower()
    {
        switch (activePower)
        {
            case 0:
                break;

            case 1:
                GameObject  landmine = Instantiate(powersObjects[activePower]);
                landmine.transform.position = transform.Find("LandminePivot").transform.position;
                landmine.SetActive(true);
                break;
            
            case 2:
                GameObject missile = Instantiate(powersObjects[activePower]);
                missile.transform.position = transform.Find("MissilePivot").transform.position;
                missile.transform.rotation = transform.rotation * Quaternion.Euler(0, 90, 0);
                missile.SetActive(true);
                break;

            case 3:
                GameObject missileAuto = Instantiate(powersObjects[activePower]);
                missileAuto.transform.position = transform.Find("MissilePivot").transform.position;
                missileAuto.transform.rotation = transform.rotation * Quaternion.Euler(0, 90, 0);
                missileAuto.SetActive(true);
                break;

            case 4:
                GameObject[] kartList = GameObject.Find("GameManager2").GetComponent<KartManager>().karts;

                foreach (GameObject kart in kartList)
                {
                    if (kart != gameObject)
                    {
                        //dar slow nos kart aqui
                    }
                }
                break;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PowerBox")
        {
            System.Random rand = new System.Random();

            int randPower = rand.Next(1, powersObjects.Length);

            activePower = randPower;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
