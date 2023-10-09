using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 1.5f;
    [SerializeField] private float _speed = 1;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    private void Update()
    {
        transform.eulerAngles += new Vector3(0, Input.GetAxis("Mouse X"), 0) * _sensitivity;
        MoveForward();
        MoveBack();
        MoveRight();
        MoveLeft();
    }

    private void MoveForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, _speed * Time.deltaTime);
        }
    }
    
    private void MoveBack()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, _speed * Time.deltaTime * -1);
        }
    }
    
    private void MoveRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
    }
    
    private void MoveLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
    }
}
