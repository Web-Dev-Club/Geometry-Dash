using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    Rigidbody rigidbody;
    bool isJumpKeyPressed = false;
    float horizontalSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && rigidbody.velocity.y == 0){
            isJumpKeyPressed = true;
        }
    }

    void FixedUpdate(){
        transform.Translate(Vector3.right * horizontalSpeed * Time.deltaTime);
        if(isJumpKeyPressed){
            rigidbody.AddForce(new Vector3(0, 5, 0), ForceMode.VelocityChange);
            isJumpKeyPressed = false;
        }
    }
}
