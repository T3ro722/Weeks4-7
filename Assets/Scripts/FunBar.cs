using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FunBar : MonoBehaviour
{
    public float fun = 10;//fun = 10
    public Slider funSlider;//create slider
    public SlimeSpawner spawner;//connect spawner
    private bool isSlimeAlive = true;

    private float funtimer = 0f;//timer

    // Start is called before the first frame update
    void Start()
    {
        funSlider.maxValue = 10;//max is always ten
        funSlider.value = fun;//value updates with fun value
    }

    // Update is called once per frame
    void Update()
    {
        if (isSlimeAlive && spawner.currentSlime != null)//only start the logic if the slime is alive
        {
            funtimer += Time.deltaTime;//time
            if (funtimer >= 3f)//decrease every 3s
            {
                fun--;
                funSlider.value = fun;
                funtimer = 0f;//reset timer

                if (fun <= 0)
                {
                    isSlimeAlive = false;//if fun =0 the slime dies
                    fun = 0;//to 0
                    funSlider.value = fun;//set value
                    spawner.KillSlime();//kill slime
                }
            }
        }
        else //if the slime does not exist, set fun to 10 (reset)
        {
            fun = 10;
            funSlider.value = fun;
            isSlimeAlive = true;
        }
    }
    public void PlaySlime() //play with slime function
    {
        if (isSlimeAlive && fun < 10) //if meets the condition (not die)
        {
            fun++;//make fun plus 1
            funSlider.value = fun; //update
        }
    }
}
