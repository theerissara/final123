using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] harzard;
    [SerializeField] private Transform[] spawnPonit;
    private float timeB;
    private float begintime;
    [SerializeField] private float startBe = 2; 
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, spawnPonit.Length);
        Transform spawnpoint = spawnPonit[randomIndex];
        Instantiate(harzard[randomIndex], spawnpoint.position,  Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeB <= 0)
        {
            int randomIndex = Random.Range(0, spawnPonit.Length);
            Transform spawnpoint = spawnPonit[randomIndex];
            randomIndex = Random.Range(0, harzard.Length);
            Instantiate(harzard[randomIndex], spawnpoint.position, Quaternion.identity);
            timeB = begintime;

        }
        else
        {
            timeB -= Time.deltaTime;
        }

        
    }
}
