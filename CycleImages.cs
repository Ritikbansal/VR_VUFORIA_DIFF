using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleImages : MonoBehaviour
{
    public GameObject images;
    public GameObject[] quads;
    int i=0;
    void Start()
    {
        foreach(GameObject g in quads)
        {
            g.SetActive(false);
        }
        quads[i].SetActive(true);
        //images.SetActive(false);
    }
    public void Right()
    {
        quads[i].SetActive(false);
        i=i+1;
        if(i==quads.Length)
        {
            i=0;
        }
        if(i==quads.Length-1)
        {
            images.SetActive(true);
            
        }else{
            images.SetActive(false);
        }
        quads[i].SetActive(true);
    }
    public void Left()
    {
        quads[i].SetActive(false);
        i=i-1;
        if(i==-1)
        {
            i=quads.Length-1;
        }
        if(i==quads.Length-1)
        {
            images.SetActive(true);
            
        }else{
            images.SetActive(false);
        }
        quads[i].SetActive(true);
    }
    public void random(int s)
    {
        foreach(GameObject g in quads)
        {
            g.SetActive(false);
        }
        i=s;
        if(s==quads.Length-1)
        {
            //images.SetActive(true);
            
        }else{
           // images.SetActive(false);
        }
        quads[s].SetActive(true);
    }
    public void Link(int i)
    {
        if(i==0)
        {
            Application.OpenURL("https://github.com/Ritikbansal");
        }
        if(i==1)
        {
            Application.OpenURL("http://www.linkedin.com/in/ritikbansal-Profile");
        }
        if(i==2)
        {
            Application.OpenURL("https://wa.me/917696558501");
        }
        if(i==3)
        {
            Application.OpenURL("https://www.instagram.com/ritik_____bansal/");
        }
    }
    public void onClicked()
    {
        print("clicked");
    }
    void Update()
    {
        
    }
}
