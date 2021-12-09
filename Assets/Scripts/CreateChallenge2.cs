using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateChallenge2 : MonoBehaviour, Challenge
{
    public GameObject KillerTile;
    public GameObject BounceTile;
    public GameObject BottomBounceTile;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(BounceTile, new Vector3(0, 0, 0) + transform.position, Quaternion.identity, transform);
        Instantiate(KillerTile, new Vector3(2, 0, 0) + transform.position, Quaternion.identity, transform);
        Instantiate(KillerTile, new Vector3(3, 1, 0) + transform.position, Quaternion.identity, transform);

        Instantiate(BottomBounceTile, new Vector3(7, 6, 0) + transform.position, Quaternion.identity, transform);
        Instantiate(KillerTile, new Vector3(9, 5, 0) + transform.position, Quaternion.identity, transform);
        Instantiate(KillerTile, new Vector3(9, 4, 0) + transform.position, Quaternion.identity, transform);


    }

    // Update is called once per frame
    void Update()
    {
    }

    public float getLength(){
        return 6;
    }
    
}
