using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KartSelect : MonoBehaviour
{
    [HideInInspector] public float xPosit = 0;
    float newXPosit;
    public static float selectedKartNumber;

    public void SwitchCarR()
    {
        xPosit += 15;
    }

    public void SwitchCarL()
    {
        xPosit -= 15;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (xPosit > 60)
        {
            xPosit = 0;
        }

        if (xPosit < 0)
        {
            xPosit = 60;
        }

        newXPosit = Mathf.MoveTowards(transform.position.x, xPosit, 0.7f);

        transform.position = new Vector3(newXPosit, transform.position.y, transform.position.z);

        selectedKartNumber = xPosit/15;
    }
}
