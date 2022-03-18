using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    Transform Camera;
    float x = 0, y = 0, deltax, deltay;
    public float sense=5f;
    public GameObject Mira;
    public 
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Camera = gameObject.GetComponent<Transform>();
        
    }
    
    void shot() 
    {
        Ray raio = new Ray(Camera.position, Camera.forward);
        RaycastHit hit;
        Physics.Raycast(raio, out hit);
		if (hit.transform.gameObject.tag == "Acertavel") 
        {

            Destroy(hit.transform.gameObject);

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shot();
        }
        deltax = Input.GetAxis("Mouse X") * sense;
        deltay = Input.GetAxis("Mouse Y") * sense;
        x += deltax;
        y -= deltay;
        y = Mathf.Clamp(y, -75f, 55f);
        transform.eulerAngles = new Vector3(y,x,0);

    }
}
