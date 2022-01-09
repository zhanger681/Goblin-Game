using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 _startPosition;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Start is called before the first frame update
    void Start()
    {
        _startPosition = rb.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(2, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {

            rb.velocity = new Vector2(rb.velocity.x, 3);
        }
    }

  // void OnCollisionEnter2D(Collision2D collision)
   //{
   //   rb.position = _startPosition ;

   //}
}
