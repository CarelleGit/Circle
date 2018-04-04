using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefencePlacement : MonoBehaviour
{
    public Camera camera;
    public GameObject defencePref;
    RaycastHit hit;
    
    // Use this for initialization
    void Start()
    {
       

      
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 objectHit = hit.point;
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(defencePref, objectHit, transform.rotation);
            }
        }
    }
}
