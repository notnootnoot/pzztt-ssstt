using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene6 : MonoBehaviour
{
    public bool forest;
    public string detectCol;
    private DetectButtonCollision2_3 detectbuttoncollision2_3;

    // Start is called before the first frame update
    void Start()
    {
        detectbuttoncollision2_3 = GameObject.FindObjectOfType<DetectButtonCollision2_3>();
        forest = false;
    }

    // Update is called once per frame
    void Update()
    {
        detectbuttoncollision2_3 = GameObject.FindObjectOfType<DetectButtonCollision2_3>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == detectCol)
        {
            Debug.Log("forest has changed");
            forest = !forest;
            detectbuttoncollision2_3.UpdateScore(forest);
        }
    }
}
