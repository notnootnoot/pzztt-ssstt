using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene2 : MonoBehaviour
{
    public bool forest;
    public string detectCol;
    private DetectButtonCollision1_2 detectbuttoncollision1_2;

    // Start is called before the first frame update
    void Start()
    {
        detectbuttoncollision1_2 = GameObject.FindObjectOfType<DetectButtonCollision1_2>();
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
            detectbuttoncollision1_2.UpdateScore(forest);
        }
    }
}
