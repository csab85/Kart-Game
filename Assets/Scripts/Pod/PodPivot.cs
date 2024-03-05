using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodPivot: MonoBehaviour
{
    //IMPORTS
    //========================
    #region



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
    void Update()
    {
        transform.position = transform.parent.transform.position + transform.parent.transform.forward * 2;
        transform.rotation = transform.parent.transform.rotation;
    }

    #endregion
    //========================


}
