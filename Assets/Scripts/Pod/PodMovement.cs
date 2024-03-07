using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.EditorTools;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PodMovement: MonoBehaviour
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
    [SerializeField][Tooltip("How quickly the pod changes its movement direction")] float turnBoost;
    [HideInInspector] public bool turning = false;
    

    //components
    Rigidbody rb;

    #endregion
    //========================


    //FUNCTIONS
    //========================
    #region

    /// <summary>
    /// Moves the pod forward or backwards
    /// </summary>
    /// <param name="direction">If positive the pod goes forward, if negative goes backwards</param>
    public void Move(float direction)
    {
        if(direction > 0)
        {
            if (!turning)
            {
                rb.AddForce(transform.forward * acceleration); //CORRGIR
            }

            if (turning)
            {
                rb.AddForce(transform.forward * acceleration * turnBoost);
            }
        }

        if(direction < 0)
        {
            rb.AddForce(transform.forward * -reverseAcceleration);
        }

        rb.drag = rb.velocity.magnitude * dragGrowth;
    }

    /// <summary>
    /// Makes the pod turn on its y axis
    /// </summary>
    /// <param name="side">If positive turns to the right, if negative to the left</param>
    public void Turn(float side)
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
        
    }

    #endregion
    //========================
}
