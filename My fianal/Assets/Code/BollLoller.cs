using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollLoller : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    private float speed = 800.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.AddForce(new Vector2(1, 2) * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
