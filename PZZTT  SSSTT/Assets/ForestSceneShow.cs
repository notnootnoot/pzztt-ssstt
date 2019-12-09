using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestSceneShow : MonoBehaviour
{
    public bool ForestS;
    // Start is called before the first frame update
    void Start()
    {
        ForestS = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScene(bool ForestS)
    {
        gameObject.GetComponent<Renderer>().enabled = ForestS;
    }
}
