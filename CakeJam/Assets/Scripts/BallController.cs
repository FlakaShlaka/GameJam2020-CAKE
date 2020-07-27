using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballspeed;
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        //float ySpeed = Input.GetAxis("Vertical");

        body.AddForce(new Vector3(0, 0, 50f) * (10f * Time.deltaTime));
        
        body.AddTorque(new Vector3(0, 0, -xSpeed) * (ballspeed * Time.deltaTime));

    }
}
