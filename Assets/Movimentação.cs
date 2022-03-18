using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{

    private Vector3 movez;
    private Vector3 movex;
    Transform corpo;
    CharacterController crt;
    public float speed = 5f;
    void Start()
    {
        crt = gameObject.GetComponent<CharacterController>();
        corpo = gameObject.GetComponent<Transform>();    
    }
   
    void Update()
    {
        movex

    }
}
