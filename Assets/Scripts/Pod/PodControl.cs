using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodControl : MonoBehaviour
{
    //IMPORTS
    //========================
    #region

    [Header ("Script Imports")]
    [SerializeField] PodMovement podMovement;

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
            podMovement.Move(Input.GetAxis("Vertical"));
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            podMovement.Turn(Input.GetAxis("Horizontal"));

            if (Input.GetAxis("Horizontal") >= 1)
            {
                GetComponent<PodMovement>().turning = true;
            }
        }

        if (Input.GetAxis("Horizontal") == 0)
        {
            GetComponent<PodMovement>().turning = false;
        }
    }

    #endregion
    //========================


}
