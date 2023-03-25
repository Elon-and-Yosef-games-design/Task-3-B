using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controller_e : MonoBehaviour
{
    [SerializeField]
    float speed = 1.0f;// step sizes

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);
    


    [SerializeField]
    //nputAction moveDown = new InputAction(type: InputActionType.Button);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
