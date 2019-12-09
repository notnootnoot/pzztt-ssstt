using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWithLever : MonoBehaviour
{

    public Transform lever;
    public float heightMultiplier;

    float height;
    Vector3 newPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        height = lever.rotation.x;
        newPos = new Vector3(transform.position.x, height*heightMultiplier, transform.position.z);
        transform.position = newPos;
    }
}
