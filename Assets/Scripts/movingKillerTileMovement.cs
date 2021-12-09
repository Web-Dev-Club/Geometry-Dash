using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingKillerTileMovement : MonoBehaviour
{
    private Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.up;
        transform.Translate(direction * Random.Range(0f,3f));
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate(){
        float speed = 2;
        if(transform.position.y > 3){
            direction = Vector3.down;
        }else if(transform.position.y < 0){
            direction = Vector3.up;
        }
        transform.Translate(speed *direction* Time.deltaTime);
    }
}
