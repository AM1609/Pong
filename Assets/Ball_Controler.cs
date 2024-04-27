using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controler : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(3f, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x >= 9f)
        {
            this.transform.position = new Vector2(0f, 0f);
        }
        if(this.transform.position.x <= -9f)
        {
            this.transform.position = new Vector2(0f, 0f);
        }
        

    }
}
