using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartControl : MonoBehaviour
{
    //IMPORTS
    //========================
    #region

    [Header ("Script Imports")]
    [SerializeField] KartMovement kartMovement;

    #endregion
    //========================


    //STATS AND VALUES
    //========================
    #region



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

    }

    //Update
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<KartPowers>().UsePower();
        }
    }

    #endregion
    //========================


}
