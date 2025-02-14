using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool isFired;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isFired)
        {
            //move
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePos - (Vector2)transform.position;
            transform.right = direction;
        }

        if (Input.GetMouseButtonDown(0))
        {
            isFired = true;
           
        }
    }
    public void Drop()
    {
        transform.parent = null;
        Destroy(gameObject, 5);

    }

    public void Fire()
    {
        isFired = true;
        transform.parent = null;
        Destroy(gameObject, 5);
    }
}


