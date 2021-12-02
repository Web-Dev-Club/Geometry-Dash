using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLayer : MonoBehaviour
{
    public GameObject[] courses;

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < 10; i++)
        {
            int num = Random.Range(0, courses.Length);

            if(courses[num] != null)
            {
                Instantiate(courses[num]);
            } else
            {
                Debug.Log("Course " + num + " doesn't exist");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
