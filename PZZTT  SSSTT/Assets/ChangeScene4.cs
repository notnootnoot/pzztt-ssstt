using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene4 : MonoBehaviour
{
    public bool forest;
    public string detectCol;
    private detectButtonCollision2 detectbuttoncollision2;

    // Start is called before the first frame update
    void Start()
    {
        detectbuttoncollision2 = GameObject.FindObjectOfType<detectButtonCollision2>();
        forest = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == detectCol)
        {
            Debug.Log("forest has changed");
            forest = !forest;
            detectbuttoncollision2.UpdateScore(forest);
        }
    }
}
