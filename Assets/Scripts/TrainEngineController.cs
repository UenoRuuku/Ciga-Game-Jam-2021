using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainEngineController : MonoBehaviour
{
    private float faceDirection;
    public float rotationSpeed;
    private Rigidbody2D rb;
    public Collider2D coll;
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
        float faceDirection = Input.GetAxisRaw("Horizontal");
        //转动
        if (horizontalmove != 0)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, transform.rotation.z + horizontalmove * rotationSpeed * Time.deltaTime); ;
        }
    }
}
