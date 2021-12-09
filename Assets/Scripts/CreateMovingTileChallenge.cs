using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CreateMovingTileChallenge : MonoBehaviour, Challenge
{
    public GameObject killerTile;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject newTile = Instantiate(killerTile);
            newTile.transform.parent = transform;
            newTile.transform.localPosition = new Vector3(i * 10, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public float getLength(){
        return 40;
    }
}
