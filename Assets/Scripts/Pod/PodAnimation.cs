using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PodAnimation : MonoBehaviour
{
    //IMPORTS
    //========================
    #region
    
    //Game Objects
    [SerializeField] GameObject pod;

    //Components
    CinemachineVirtualCamera cam;

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
        cam = GetComponent<CinemachineVirtualCamera>();
    }

    #endregion
    //========================


}
