using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SlimeChangeColour : MonoBehaviour
{
    public TMP_Dropdown dropdown;//Use TMP dropdown
    public SpriteRenderer slimeSprite;//use slime spriterenderer

    // Start is called before the first frame update
    void Start()
    {//make sure the slime start as og colour
        if (slimeSprite != null)
        {
            slimeSprite.color = Color.white;
        }
        dropdown.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColour(int index)
    {
        // Colour array
        Color[] colors = { Color.white, Color.red, Color.green};

        // make sure index is in range
        if (index >= 0 && index < colors.Length)
        {
            Color newColor = colors[index];

            if (slimeSprite == null)
            {
                // get current slime
                slimeSprite = FindObjectOfType<SpriteRenderer>();
            }

            if (slimeSprite != null)
            {
                slimeSprite.color = Color.white;
                slimeSprite.color = newColor;
            }
            else
            {
                Debug.LogError("No Slime found in the scene!");
            }
        }
    }
}
