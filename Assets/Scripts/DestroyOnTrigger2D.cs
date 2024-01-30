using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]

    public float dead_Caveman;



    private void Update()
    {
        if (transform.position.y < dead_Caveman)
        {
            Destroy(this.gameObject);
        }
        /* Just to show the enabled checkbox in Editor */
    }
}