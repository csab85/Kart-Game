using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PodAnimation : MonoBehaviour
{
    //IMPORTS
    //========================
    #region

    //Components
    [SerializeField] CinemachineVirtualCamera cam;
    Rigidbody rb;

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
        rb = GetComponent<Rigidbody>();
    }

    //Update
    void Update()
    {
        cam.m_Lens.FieldOfView = 60 + Mathf.Abs(rb.velocity.z) * 2;

        cam.m_Lens.Dutch = rb.velocity.x * 1.5f;
        print(rb.velocity);
    }

    #endregion
    //========================


}
