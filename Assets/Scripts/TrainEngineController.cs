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
    public float rotateZ;
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
        //转动
        if (horizontalmove != 0)
        {
            rotateZ = transform.rotation.z;
            transform.rotation = Quaternion.Euler(0f, 0f,  transform.eulerAngles.z+horizontalmove * rotationSpeed * Time.deltaTime) ;
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x+runSpeed * Time.deltaTime* transform.rotation.x, rb.velocity.y + runSpeed * Time.deltaTime * transform.rotation.y);
        }
    }
}
