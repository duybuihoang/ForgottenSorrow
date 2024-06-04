using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get { return instance; } }

    [SerializeField] protected Vector3 mouseWorldPos;


    private void Awake()
    {
        if (InputManager.instance != null)
            Debug.LogError("only 1 InputManager allow to exist!!!");
        InputManager.instance = this;
    }

    private void FixedUpdate()
    {
        this.getMousePos();
    }

    protected virtual void getMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(Input.mousePosition);
    }

}
