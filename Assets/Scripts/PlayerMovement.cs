using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float playerJumpForce;
    Rigidbody rb;
    ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * playerJumpForce);
            Physics.gravity *= -1;
        }
        score.ScoreCalculator((int)rb.transform.position.x);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(playerSpeed, rb.velocity.y, rb.velocity.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ObstacleCollider>() != null)
        {
            Destroy(this.gameObject);
        }
    }

}
