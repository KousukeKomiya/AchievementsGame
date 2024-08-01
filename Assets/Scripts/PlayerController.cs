using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 direction = new Vector2(x*PlayerSpeed, y*PlayerSpeed);
        

        rb.AddForce(direction);
        rb.velocity = direction * Time.deltaTime*1000f;
    }
}
