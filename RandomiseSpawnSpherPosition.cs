using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseSpawnSpherPosition : MonoBehaviour
{
    float negativePosition = -7;
    float positivePosition = 7;

    void Start()
    {
        transform.position = new Vector2(Random.Range(negativePosition, positivePosition), transform.position.y);
    }
}
