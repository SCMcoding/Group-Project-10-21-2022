using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ap : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SpeedUp;



    bool isActive;

    public void activate1(InputAction.CallbackContext context)
    {
        isActive = !isActive;
        SpeedUp.SetActive(isActive);
    }

}
