using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool PlayeOnGround;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            PlayeOnGround = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            PlayeOnGround = false;
        }
    }
}
