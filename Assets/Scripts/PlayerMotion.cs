using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    Rigidbody rigidbody;
    bool isJumpKeyPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && rigidbody.velocity.y == 0){
            isJumpKeyPressed = true;
        }
    }

    void FixedUpdate(){
        if(isJumpKeyPressed){
            rigidbody.AddForce(new Vector3(0, 5, 0), ForceMode.VelocityChange);
            isJumpKeyPressed = false;
        }
    }
}
