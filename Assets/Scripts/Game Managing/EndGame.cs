using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] StartKart startKart;

    static public int winnerPlayer;
    [SerializeField] int laps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject kart in startKart.karts)
        {
            if (kart.activeSelf)
            {
                print(kart);
                if (kart.GetComponent<KartControl>().lapsCount/6 >= laps)
                {
                    winnerPlayer = kart.GetComponent<KartControl>().playerNumber;
                    SceneManager.LoadScene("CenaVitoria");
                }
            }
        }
    }
}
