using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public float hunger = 10;//hunger = 10
    public Slider hungerSlider;//create slider
    public SlimeSpawner spawner;//connect spawner
    private bool isSlimeAlive = true;

    private float hungertimer = 0f;//timer

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = 10;//max is always ten
        hungerSlider.value = hunger;//value updates with hunger value
    }

    // Update is called once per frame
    void Update()
    {
        if (isSlimeAlive && spawner.currentSlime !=null)//only start the logic if the slime is alive
        {
            hungertimer += Time.deltaTime;//time
            if (hungertimer >= 2f)//decrease every 2s
            {
                hunger--;
                hungerSlider.value = hunger;
                hungertimer = 0f;//reset timer

                if (hunger <= 0)
                {
                    isSlimeAlive = false;//if hunger =0 the slime dies
                    hunger = 0;//to 0
                    hungerSlider.value = hunger;//set value
                    spawner.KillSlime();//kill slime
                }
            }
        }
        else //if the slime does not exist, set hunger to 10 (reset)
        {
            hunger = 10;
            hungerSlider.value = hunger;
        }
    }
   public void FeedSlime() //feed slime function
    {
        if (isSlimeAlive && hunger <10) //if meets the condition (not die)
        {
            hunger++;//make hunger plus 1
            hungerSlider.value = hunger; //update
        }
    }
}
