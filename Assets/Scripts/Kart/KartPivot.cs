using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartPivot: MonoBehaviour
{
    //IMPORTS
    //========================
    #region



    #endregion
    //========================


    //STATS AND VALUES
    //========================
    #region

    [SerializeField] Vector3 distance;

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
        transform.position = GameObject.Find("PlayerPod").transform.position;
        transform.rotation = GameObject.Find("PlayerPod").transform.rotation;
    }

    #endregion
    //========================


}
