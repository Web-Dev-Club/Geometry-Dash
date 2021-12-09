using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBouncingChallenge : MonoBehaviour, Challenge
{
    // Start is called before the first frame update
    public GameObject bouncer;
    public GameObject killerTile;
    void Start()
    {
        Instantiate(bouncer, new Vector3(0, 0, 0) + transform.position, Quaternion.identity, transform);
        Instantiate(killerTile, new Vector3(2, 0, 0) + transform.position, Quaternion.identity, transform);
        Instantiate(killerTile, new Vector3(2, 1, 0) + transform.position, Quaternion.identity, transform);

        Instantiate(bouncer, new Vector3(8, 2, 0) + transform.position, Quaternion.identity, transform);
        Instantiate(killerTile, new Vector3(10, 2, 0) + transform.position, Quaternion.identity, transform);
        Instantiate(killerTile, new Vector3(10, 3, 0) + transform.position, Quaternion.identity, transform);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float getLength(){
        return 10;
    }
}
