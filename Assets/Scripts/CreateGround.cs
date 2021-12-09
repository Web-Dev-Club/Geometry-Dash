using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGround : MonoBehaviour
{
    public GameObject groundTile;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -20; i < 200; i++){
            GameObject newTile = Instantiate(groundTile);
            newTile.transform.parent = transform;
            newTile.transform.localPosition = new Vector3(i, 0, 0);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    
}
