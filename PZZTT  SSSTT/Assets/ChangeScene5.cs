using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene5 : MonoBehaviour
{
    public bool forest;
    public string detectCol;
    private DetectButtonCollision2_2 detectbuttoncollision2_2;

    // Start is called before the first frame update
    void Start()
    {
        detectbuttoncollision2_2 = GameObject.FindObjectOfType<DetectButtonCollision2_2>();
        forest = false;
    }

    // Update is called once per frame
    void Update()
    {
        detectbuttoncollision2_2 = GameObject.FindObjectOfType<DetectButtonCollision2_2>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == detectCol)
        {
            Debug.Log("forest has changed");
            forest = !forest;
            detectbuttoncollision2_2.UpdateScore(forest);
        }
    }
}
