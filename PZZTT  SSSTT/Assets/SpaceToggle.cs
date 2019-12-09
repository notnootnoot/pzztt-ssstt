using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceToggle : MonoBehaviour
{
    public bool Space;
    public string detectCol;
    private ShowSpaceScene showspacescene;

    // Start is called before the first frame update
    void Start()
    {
        showspacescene = GameObject.FindObjectOfType<ShowSpaceScene>();
        Space = false;
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == detectCol)
        {
            Debug.Log("Space has changed");
            Space = !Space;
            showspacescene.UpdateScene(Space);
        }
    }
}
