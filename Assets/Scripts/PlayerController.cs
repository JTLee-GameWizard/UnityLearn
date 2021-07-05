using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] float xValue = 0.01f;
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float zValue = 0.01f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(xValue,yValue,zValue);
    }
}
