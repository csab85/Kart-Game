using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HijackAll : MonoBehaviour
{
    IEnumerator DisableAllMovement()
    {
        GameObject[] karts = GameObject.Find("GameManager2").GetComponent<StartKart>().karts;

        foreach (GameObject kart in karts)
        {
            if (kart != gameObject.transform.parent.gameObject)
            {
                GetComponent<Hijack>().DisableControl(kart, 2);
            }
        }

        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

    void Start()
    {
        StartCoroutine(DisableAllMovement());
    }

    void Update()
    {
        Vector3 parentPosition = transform.parent.transform.position;
        transform.position = new Vector3(parentPosition.x, 3, parentPosition.z);
    }
}
