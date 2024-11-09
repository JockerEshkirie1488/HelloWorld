using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crickets : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        Destroy(cube);
    }

    void Update()
    {
        print("Crickets");
    }
}
