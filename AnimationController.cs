using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator a;
    bool play=false;
    void Start()
    {
        
    }
    public void OnClickPlay(int i)
    {   if(i==0)
        {
            a.SetTrigger("idleTrigger");
        }else
        if(i==1)
        {
            a.SetTrigger("attackTrigger1");
        }else if(i==2)
        {
            a.SetTrigger("attackTrigger2");
        }
        else if(i==3)
        {
            a.SetTrigger("rotateTrigger");
        }else if(i==4)
        {
            a.SetTrigger("highTrigger");
        }
    }
    
}
