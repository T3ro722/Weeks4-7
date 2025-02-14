using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{
    public GameObject slimePrefab; //slime prefab
    private GameObject currentSlime; //track slime
    public RectTransform uiAnchor; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnSlime()
    {
        if (currentSlime == null)
        { //ensure there's only one slime present
            currentSlime = Instantiate(slimePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        } //instantiate slime

        //assign UI anchor
        SlimeMoveWithUI slimeScript = currentSlime.GetComponent<SlimeMoveWithUI>();
        if (slimeScript != null)
        {
            slimeScript.UIAnchor = uiAnchor; //give it value
        }
    }

    public void KillSlime()
    {
        if (currentSlime != null) //if there is a slime present
        {
            Destroy(currentSlime);//kill the slime
            currentSlime = null; //reset slime status
        }
    } 
}
