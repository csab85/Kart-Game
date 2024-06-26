using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using Unity.VisualScripting;
using UnityEngine;

public class KartControl : MonoBehaviour
{
    //IMPORTS
    //========================
    #region

    [SerializeField][Range(1, 2)] public int playerNumber;

    #endregion
    //========================


    //STATS AND VALUES
    //========================
    #region

    public int lapsCount;

    #endregion
    //========================


    //FUNCTIONS
    //========================
    #region

    #endregion
    //========================


    //RUNNING
    //========================
    #region

    //Start
    void Start()
    {
        if (playerNumber == 1)
        {
            GetComponent<KeyboardInput>().TurnInputName = "HorizontalP1";
            GetComponent<KeyboardInput>().AccelerateButtonName = "AccelerateP1";
            GetComponent<KeyboardInput>().BrakeButtonName = "BrakeP1";
            GetComponent<KartPowers>().powerButton = "PowerP1";
        }

        else
        {
            GetComponent<KeyboardInput>().TurnInputName = "HorizontalP2";
            GetComponent<KeyboardInput>().AccelerateButtonName = "AccelerateP2";
            GetComponent<KeyboardInput>().BrakeButtonName = "BrakeP2";
            GetComponent<KartPowers>().powerButton = "PowerP2";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LapCounter")
        {
            lapsCount += 1;
        }
    }

    #endregion
    //========================


}
