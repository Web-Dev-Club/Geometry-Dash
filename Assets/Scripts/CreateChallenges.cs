using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CreateChallenges : MonoBehaviour
{
    public GameObject Challenge1;
    public GameObject Challenge2;
    public GameObject movingTileChallenge;
    public GameObject bouncingChallenge;
    float startDistance = 15;
    float AverageChallengeLength = 40;
    float betweenDistance = 20;
    // Start is called before the first frame update
    void Start()
    {
        float bouncingChallengeLength = bouncingChallenge.GetComponent<CreateBouncingChallenge>().getLength();
        float movingTileChallengeLength = movingTileChallenge.GetComponent<CreateMovingTileChallenge>().getLength();

        float distance = startDistance;
        for (int i = 0; i < 5; i++)
        {
            GameObject challenge = generateRandomChallenge();
            Instantiate(challenge, new Vector3(distance, 0, 0) + transform.position, Quaternion.identity, transform);
            distance += challenge.GetComponent<Challenge>().getLength() + betweenDistance;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    GameObject generateRandomChallenge()
    {
        // int randInt = Random.Range(2, 2);
        int randInt = Random.Range(1, 5);
        switch (randInt)
        {
            case 1:
                return Challenge1;
            case 2:
                return Challenge2;
            case 3:
                return bouncingChallenge;
            case 4:
                return movingTileChallenge;
            default:
                return null;
        }
    }
}
