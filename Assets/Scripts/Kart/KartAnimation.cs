using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class KartAnimation : MonoBehaviour
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
        //Camera
        cam.m_Lens.FieldOfView = 60 + Mathf.Abs(rb.velocity.magnitude) * 2;

        cam.m_Lens.Dutch = rb.velocity.x * 1.5f;
        

        //kart
        //transform.rotation = Quaternion.Euler(new Vector3(, transform.rotation.y, rb.velocity.x));

    }

    #endregion
    //========================


}
