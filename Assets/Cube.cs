using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Vector3 cubePos = new Vector3(-0.8f, 4, 0); //¼Ä¤Hªº¦ì¸m
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = cubePos;
    }

    // Update is called once per frame
    void Update()
    {
        cubePos = new Vector3(this.transform.position.y,
    this.transform.position.z);
        this.gameObject.transform.position = cubePos;
    }
}
