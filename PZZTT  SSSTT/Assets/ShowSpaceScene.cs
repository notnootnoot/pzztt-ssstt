using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSpaceScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScene(bool Space)
    {
        gameObject.GetComponent<Renderer>().enabled = Space;
    }

}
