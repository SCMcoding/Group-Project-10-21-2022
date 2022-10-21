using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class NewBehaviourScript5 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject particle;
    bool isActive;

    public void activate(InputAction.CallbackContext context)
    {

        particle.SetActive(!isActive);
    }
}
