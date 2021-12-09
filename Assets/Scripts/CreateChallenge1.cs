using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateChallenge1 : MonoBehaviour, Challenge
{
    // Start is called before the first frame update
    public GameObject bouncer;
    public GameObject killerTile;
    private int jumpLength = 7;
    void Start()
    {
        Instantiate(bouncer, new Vector3(0, 0, 0) + transform.position, Quaternion.identity, transform);
        for (int i = 1; i < 1+jumpLength;i++){
        Instantiate(killerTile, new Vector3(i, 0, 0) + transform.position, Quaternion.identity, transform);  
        }

        Instantiate(bouncer, new Vector3(jumpLength+2, 0, 0) + transform.position, Quaternion.identity, transform);  
        for (int i = jumpLength+4; i < jumpLength*2+4;i++){
        Instantiate(killerTile, new Vector3(i, 0, 0) + transform.position, Quaternion.identity, transform);  
        }  

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getLength(){
        return 16;
    }
}
