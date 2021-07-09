using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainEngineController : MonoBehaviour
{
    private float faceDirection;
    public float rotationSpeed;
    public float runSpeed;
    private Rigidbody2D rb;
    public Collider2D coll;
    public float 测试;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        测试 = Mathf.Cos(transform.eulerAngles.z * Mathf.Deg2Rad);
        //转动
        if (horizontalmove != 0)
        {
 
            transform.rotation = Quaternion.Euler(0f, 0f, - transform.eulerAngles.z-horizontalmove * rotationSpeed * Time.deltaTime) ;
        }
        if (Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(runSpeed * Time.deltaTime* Mathf.Cos(transform.eulerAngles.z * Mathf.Deg2Rad),  runSpeed * Time.deltaTime *Mathf.Sin(transform.eulerAngles.z * Mathf.Deg2Rad));
        }
        if (Input.GetButtonUp("Jump"))
        {
            rb.velocity = new Vector2(0f,0f);
        }
    }
}
