using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Vector3 posy = transform.position;
            posy.y += 0.01f;
            transform.position = posy;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 posy = transform.position;
            posy.y -= 0.01f;
            transform.position = posy;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 posx = transform.position;
            posx.x -= 0.01f;
            transform.position = posx;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 posx = transform.position;
            posx.x += 0.01f;
            transform.position = posx;
        }
    }
}
