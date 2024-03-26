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
        if (Input.GetAxis("Vertical") != 0)
        {
            kartMovement.Move(Input.GetAxis("Vertical"));
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            kartMovement.Turn(Input.GetAxis("Horizontal"));

            if (Input.GetAxis("Horizontal") >= 1)
            {
                GetComponent<KartMovement>().turning = true;
            }
        }

        else
        {
            GetComponent<KartMovement>().turning = false;
        }
    }

    #endregion
    //========================


}
