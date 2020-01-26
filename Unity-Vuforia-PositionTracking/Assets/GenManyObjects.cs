using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenManyObjects : MonoBehaviour
{
    public GameObject targetGameObject;
    public float MinRange, MaxRange;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 500; i++) {
            Instantiate(
                targetGameObject,
                new Vector3(Random.Range(MinRange, MaxRange),
                    Random.Range(MinRange, MaxRange),
                    Random.Range(MinRange, MaxRange)
                ),
                Quaternion.Euler(
                    Random.Range(0, 180),
                    Random.Range(0, 180),
                    Random.Range(0, 180)
                )
            );
        }
    }
}
