using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangScene3 : MonoBehaviour
{
    public bool forest;
    public string detectCol;
    private DetectButtonCollision1_3 detectbuttoncollision1_3;

    // Start is called before the first frame update
    void Start()
    {
        detectbuttoncollision1_3 = GameObject.FindObjectOfType<DetectButtonCollision1_3>();
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
            detectbuttoncollision1_3.UpdateScore(forest);
        }
    }
}
