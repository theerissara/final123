using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] private float MinSpeed;
    [SerializeField] private float maxSpeed;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(MinSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
    }
}
