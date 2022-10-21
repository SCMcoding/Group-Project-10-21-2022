using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject action1;
  


    bool isActive;

    public void activate1(InputAction.CallbackContext context)
    {
        isActive = !isActive;
        action1.SetActive(isActive);

    }

}