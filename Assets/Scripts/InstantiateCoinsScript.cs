using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCoinsScript : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject blueCoin;
    public GameObject goldCoin;
    public GameObject silverCoin;
    public GameObject purpleCoin;
    private int blueCoinAmount;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        //Instantiate(blueCoin, new Vector3(0, 0, 0), Quaternion.identity);

        blueCoinAmount = 10;

        for (int x = 0; x < blueCoinAmount; ++x)
        {
            Instantiate(blueCoin, new Vector3(5.0f+x, 0.4f, 2.0f+x), Quaternion.identity);
            Instantiate(goldCoin, new Vector3(5.0f+x, 0.4f, 3.0f+x), Quaternion.identity);
            Instantiate(silverCoin, new Vector3(5.0f+x, 0.4f, 1.0f+x), Quaternion.identity);
            Instantiate(purpleCoin, new Vector3(5.0f+x, 0.4f, 4.0f+x), Quaternion.identity);
        }
    }
}
