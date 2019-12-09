﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithLevertop : MonoBehaviour
{

    public Transform lever;
    public float heightMultiplier;
    public float widthMultiplier;

    float height;
    float width;
    Vector3 newPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        height = lever.rotation.x;
        width = lever.rotation.x;
        newPos = new Vector3(width * widthMultiplier, height * heightMultiplier, transform.position.z);
        transform.position = newPos;
    }
}