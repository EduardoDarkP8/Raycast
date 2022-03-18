using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancado : MonoBehaviour
{
    Collider bala;

    // Start is called before the first frame update
    void Start()
    {
        bala = gameObject.GetComponent<Collider>();    
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision coli) 
    {
        Debug.Log(coli.collider.name);
    }
}
