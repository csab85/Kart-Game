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

    [SerializeField] StartKart startKart;

    [SerializeField] public int activePower;
    public string powerButton;
    public int waypointCheck;

    [SerializeField]
    public Dictionary<float, string> powersDict = new Dictionary<float, string>()
    {
        {0, "none"},
        {1, "landmine"},
        {2, "missile"},
        {3, "auto missile"},
        {4, "hourglass"},
        {5, "wormhole"}
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

                foreach (GameObject kart in startKart.karts)
                {
                    if (kart != gameObject && kart.activeSelf)
                    {
                        missileAuto.GetComponent<Move>().targetTransform = kart.transform;
                        missileAuto.GetComponent<CollisionHijack>().sender = gameObject;
                    }
                }

                missileAuto.SetActive(true);
                break;

            case 4:
                GameObject[] kartList = GameObject.Find("GameManager2").GetComponent<KartManager>().karts;

                GameObject hourglass = Instantiate(powersObjects[activePower]);
                hourglass.transform.parent = gameObject.transform;
                hourglass.SetActive(true);                

                break;

            case 5:
                GameObject wormhole = Instantiate(powersObjects[activePower]);
                wormhole.transform.position = transform.Find("MissilePivot").transform.position;
                wormhole.transform.rotation = transform.rotation;
                wormhole.SetActive(true);

                break;

        }

        activePower = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PowerBox" && other.GetComponent<PowerBox>().visible)
        {
            other.GetComponent<PowerBox>().visible = false;

            System.Random rand = new System.Random();

            int randPower = rand.Next(1, powersObjects.Length);

            activePower = randPower;
        }

        if (other.tag == "WaypointCheck")
        {
            waypointCheck ++;

            if (waypointCheck >= 8)
            {
                waypointCheck = 0;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(powerButton))
        {
            UsePower(); 
        }
    }
}
