using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpheres : MonoBehaviour
{
    [SerializeField] Transform sphere;

    void Start()
    {
        SetActiveFirstSphere();
    }

    private void SetActiveFirstSphere()
    {
        sphere.gameObject.SetActive(true);
        sphere.position = transform.position;
    }
}
