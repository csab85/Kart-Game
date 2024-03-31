using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Unity.VisualScripting;
using UnityEngine;

public class PowerBox : MonoBehaviour
{
    [HideInInspector] public bool visible = true;

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(5);
        GetComponent<MeshRenderer>().enabled = true;
        visible = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!visible)
        {
            StartCoroutine(Cooldown());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && visible)
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
