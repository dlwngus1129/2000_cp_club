using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;


public class ex : MonoBehaviour
{
    public float speed = 0.3f;
    public int jump = 1;
    public static int jump_count = 0;
    public float dash_speed = 0;

    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed*Time.deltaTime);
            transform.localScale = new Vector3(1,1,1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed*Time.deltaTime);
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (jump_count < 2)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump, ForceMode2D.Impulse);
                jump_count++;
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            if (gameObject.transform.localScale = (1,1,1))
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.right * dash_speed, ForceMode2D.Impulse);
            }

            if (gameobject.sacle == -1)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.left * dash_speed, ForceMode2D.Impulse);
            }
        }
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (GameObject.FindWithTag("wall"))
        {
            jump_count = 0;
        }
    }
}
    

        
    

    

