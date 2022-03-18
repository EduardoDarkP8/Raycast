using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checar : MonoBehaviour
{
    public GameObject Camera;
    Transform CameraT;
    Image img;
    // Start is called before the first frame update
    void Start()
    {
        CameraT = Camera.GetComponent<Transform>();
        img = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray raioDeVer = new Ray(CameraT.position, CameraT.forward);
        RaycastHit HitC;
        Physics.Raycast(raioDeVer, out HitC);
		if (HitC.transform.gameObject.tag == "Acertavel") 
        {
            img.color = Color.red;
        }
		else 
        {
            img.color = Color.white;
        }
		
    }
}
