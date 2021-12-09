using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidBody;
    private bool jumpKeyPressed;
    private float horizontalSpeed = 6.5f;
    // Start is called before the first frame update
    void Start()
    {
        jumpKeyPressed = false;
        rigidBody = GetComponent<Rigidbody>();

        Physics.gravity = new Vector3(0, -12.0F, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Math.Abs(rigidBody.velocity.y) < 0.001){
            jumpKeyPressed = true;
        }
    }

    void FixedUpdate(){
        transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
        if(jumpKeyPressed){
            float jumpVelocity = 9;
            rigidBody.AddForce(new Vector3(0, jumpVelocity, 0), ForceMode.VelocityChange);
            jumpKeyPressed = false;
        }
    }
    void OnCollisionEnter(Collision collision){
        print("entered");
        GameObject other = collision.gameObject;
        int layer = other.layer;
        print("Layer is " + layer);
        switch(layer){
            case 6:
                if(other.gameObject.transform.position.y < transform.position.y){
                    float bounceVelocity = 10;
                    rigidBody.velocity = new Vector3(rigidBody.velocity.x, bounceVelocity, rigidBody.velocity.z);
                }
                break;
            case 7:
                transform.position = new Vector3(0, 0, 0);
                break;
            case 8:
                if((other.gameObject.transform.position.y-1/2) > transform.position.y){
                    float bounceVelocity = -10;
                    rigidBody.velocity = new Vector3(rigidBody.velocity.x, bounceVelocity, rigidBody.velocity.z);
                }
                break;
            default:
                break;

        }
    }
}
