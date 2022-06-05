using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yan1 : MonoBehaviour
{
    [SerializeField] private GameObject targetball;
    [SerializeField] private float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per fram
    void Update()
    {
        if(transform.position.y > targetball.transform.position.y)
         { transform.Translate(-Vector3.up * Time.deltaTime * speed); }
        if (transform.position.y < targetball.transform.position.y)
        { transform.Translate(Vector3.up * Time.deltaTime * speed); }
    }
}
