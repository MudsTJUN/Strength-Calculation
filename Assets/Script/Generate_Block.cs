using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_Block : MonoBehaviour
{
    public GameObject blockPrefabs; // 生成するブロックのPrefab
    private UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(20,20,20);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnBlock", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBlock()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(blockPrefabs, spawnPos, blockPrefabs.transform.rotation)
        }
    }
}
