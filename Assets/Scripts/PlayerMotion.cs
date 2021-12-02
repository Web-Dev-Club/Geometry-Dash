using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    Rigidbody rigidbody;
    bool isJumpKeyPressed = false;
    float horizontalSpeed = 5;
    public Vector3 gravity = new Vector3(0, -3F, 0);
    public Vector3 jumpPower = new Vector3(0, 8, 0);
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity = gravity;

        if (Input.GetKeyDown(KeyCode.Space) ){
            if (Mathf.Floor(Mathf.Abs(rigidbody.velocity.y)) < 0.05)
            {
                isJumpKeyPressed = true;
            }
        } 

    }

    void FixedUpdate(){
        transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
        if(isJumpKeyPressed){
            rigidbody.AddForce(jumpPower, ForceMode.VelocityChange);
            isJumpKeyPressed = false;
        }
    }
}
