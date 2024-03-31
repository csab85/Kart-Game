using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Hijack : MonoBehaviour
{
    public void DisableControl(GameObject target, float cooldownTime)
    {
        target.GetComponent<ArcadeKart>().enabled = false;
        StartCoroutine(DisableControlCooldown(target, cooldownTime));
    }

    IEnumerator DisableControlCooldown(GameObject target, float cooldownTime)
    {
        yield return new WaitForSeconds(cooldownTime);
        target.GetComponent<ArcadeKart>().enabled = true;

        if(gameObject.tag == "Killable")
        {
            Destroy(gameObject);
        }
    }
}