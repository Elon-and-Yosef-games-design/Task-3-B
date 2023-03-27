using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class controller_e : MonoBehaviour
{

    [SerializeField]
    float speed = 1.0f;// step sizes

    [SerializeField]
    InputAction moveUp = new InputAction();

    [SerializeField]
    InputAction moveDown = new InputAction();

    [SerializeField]
    InputAction moveLeft = new InputAction();

    [SerializeField]
    InputAction moveRight = new InputAction();


    private void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
        moveLeft.Enable();
        moveRight.Enable();
    }


    // Update is called once per frame
    void Update()
    {
        if (moveUp.IsPressed())
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        if (moveDown.IsPressed())
            transform.position += new Vector3(0, -1 * speed * Time.deltaTime, 0);
        if (moveLeft.IsPressed())
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        if (moveRight.IsPressed())
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
