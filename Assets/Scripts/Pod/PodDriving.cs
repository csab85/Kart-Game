using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.EditorTools;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PodDriving: MonoBehaviour
{
    //IMPORTS
    //========================
    #region



    #endregion
    //========================


    //STATS AND VALUES
    //========================
    #region

    [Header ("Movement Config")]

    [SerializeField] float acceleration;
    [SerializeField] float reverseAcceleration;
    [SerializeField] float dragGrowth;
    [SerializeField] [Tooltip ("How fast the pod turns its body")] float angularAcceleration;
    [SerializeField] float angularDragGrowth;
    

    //components
    Rigidbody rb;

    public bool force = false;
    public bool torque = false;

    #endregion
    //========================


    //FUNCTIONS
    //========================
    #region

    /// <summary>
    /// Moves the pod forward or backwards
    /// </summary>
    /// <param name="direction">If positive the pod goes forward, if negative goes backwards</param>
    void Move(float direction)
    {
        if(direction > 0)
        {
            rb.AddForce(transform.forward * acceleration);
        }

        if(direction < 0)
        {
            rb.AddForce(transform.forward * -reverseAcceleration);
        }

        rb.drag = rb.velocity.magnitude * dragGrowth;
    }

    void Turn(float side)
    {
        if (side > 0)
        {
            rb.AddTorque(new Vector3(0, angularAcceleration, 0));
        }

        if (side < 0)
        {
            rb.AddTorque(new Vector3(0, -angularAcceleration, 0));
        }

        rb.angularDrag = rb.angularVelocity.magnitude * angularDragGrowth;
    }

    #endregion
    //========================


    //RUNNING
    //========================
    #region

    //Start
    void Start()
    {
        //get components
        rb = GetComponent<Rigidbody>();
    }

    //Update
    void FixedUpdate()
    {
        if (force)
        {
            Move(1);
        }

        if (torque)
        {
            Turn(1);
        }
    }

    #endregion
    //========================
}
