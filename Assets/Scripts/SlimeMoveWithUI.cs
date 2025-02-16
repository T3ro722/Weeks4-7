using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMoveWithUI: MonoBehaviour
{
    public RectTransform UIAnchor;//UI anchor

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UIAnchor! == null) //UI isnt null
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(UIAnchor.position);//Change to world point
            transform.position = new Vector3(worldPos.x,worldPos.y,0);//make slime follow UI anchor
        }
    }
}
