using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHijack : MonoBehaviour
{
    [SerializeField] float hijackDuration;
    bool collided = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!collided)
            {
                tag = "Killable";
                GetComponent<Hijack>().DisableControl(other.gameObject, hijackDuration);
                collided = true;
                GetComponent<MeshRenderer>().enabled = false;
            }
        }

        else
        {
        //     if (!collided)
        //     {
        //         Destroy(gameObject);
        //     }
        // }
        }
    }
}