using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    private static List<GameObject> all_blocks;

    public static void Spawn(GameObject block)
    {
        for (int i = 1; i < 15; i++)
        {
            Instantiate(block, new Vector3(0, 0.5f, -80 - i*2));
        }
    }

    private static GameObject Instantiate(GameObject block, Vector3 vector3)
    {
        throw new NotImplementedException();
    }
}
