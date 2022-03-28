using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera cam;
    public GameObject player;
    public GameObject[] blockPrefab;
    public float spawnPoint = 0;
    public float spawnMargine;


    // Update is called once per frame
    void Update()
    {
        // camera follow player
        if (player != null)
        {
            cam.transform.position = new Vector3(player.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        }

        // Spawning random blocks
        int randomValue = UnityEngine.Random.Range(0, blockPrefab.Length);
        if (spawnPoint < 10)
        {
            randomValue = 0;
        }

        while ((player != null) && (spawnPoint < player.transform.position.x + spawnMargine))
        {
            GameObject temp = Instantiate(blockPrefab[randomValue]);
            PlatformController platform = temp.GetComponent<PlatformController>();
            temp.transform.position = new Vector3(spawnPoint + platform.platformSize / 2, 0, 0);
            spawnPoint = spawnPoint + platform.platformSize;
        }



    }

}
