using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMoveDungeon : MonoBehaviour
{
    public float slimetimer = 0f;
    public float switchtime = 2f;
    public bool isup = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 sposy = transform.position;
        sposy.y = 0.002f;
        transform.position = sposy;

        slimetimer += Time.deltaTime;
        if (isup)
        {
            sposy.y += 0.002f;
            transform.position = sposy;
            
        } else
        {
            sposy.y -= 0.002f;
            transform.position = sposy;
        }

        transform.position = sposy;
        slimetimer += Time.deltaTime;

        if(slimetimer > switchtime)
        {
            isup = false;
         
        }
    }
}
