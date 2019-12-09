using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public bool forest;
    public string detectCol;
    private detectButtonCollision detectbuttoncollision;

    // Start is called before the first frame update
    void Start()
    {
        detectbuttoncollision = GameObject.FindObjectOfType<detectButtonCollision>();
        forest = false;
    }

    // Update is called once per frame
    void Update()
    {
        detectbuttoncollision = GameObject.FindObjectOfType<detectButtonCollision>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == detectCol)
        {
            Debug.Log("forest has changed");
            forest = !forest;
            detectbuttoncollision.UpdateScore(forest);
        }
    }   
}
