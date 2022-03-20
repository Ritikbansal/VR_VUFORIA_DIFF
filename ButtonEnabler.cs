using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonEnabler : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public GameObject images;
    public void OnClickStart()
    {
        go1.SetActive(true); go2.SetActive(true);
    }
    public void OnClickEnd()
    {
        go1.SetActive(false); go2.SetActive(false);
        images.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
