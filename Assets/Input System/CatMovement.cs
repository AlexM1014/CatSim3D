using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CatMovement : MonoBehaviour
{
    public Rigidbody catRB;

    public void Jump(InputAction.CallbackContext context)
    {
        catRB.AddForce(transform.up * 100f);
    }
}
