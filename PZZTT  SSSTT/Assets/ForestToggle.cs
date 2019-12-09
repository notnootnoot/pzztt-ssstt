using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestToggle : MonoBehaviour
{
    public bool ForestS;
    public string detectCol;
    private ForestSceneShow forestsceneshow;

    // Start is called before the first frame update
    void Start()
    {
        forestsceneshow = GameObject.FindObjectOfType<ForestSceneShow>();
       ForestS= true;
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
            ForestS = !ForestS;
            forestsceneshow.UpdateScene(ForestS);
        }
    }
}
