using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    private static List<GameObject> all_blocks;

    public GameObject prefab;

    void Start()
    {
        Spawn(prefab);
    }

    public static void Spawn(GameObject block)
    {
        System.Random rnd = new System.Random();
        for (int i = 1; i < 15; i++)
        {
            Instantiate(block, new Vector3(0, 0.5f, -80 + i * 3 * rnd.Next(1, 3)), Quaternion.Euler(0, 0, 0));
        }
    }
}
