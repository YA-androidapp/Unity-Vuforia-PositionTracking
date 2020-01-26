using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Random.Range(0, 180),
            Random.Range(0, 180),
            Random.Range(0, 180)
        ) * Time.deltaTime);
    }
}
