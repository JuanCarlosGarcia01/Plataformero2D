using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{

    public static bool isGrounded;

    private void OntriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    private void OntriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}
