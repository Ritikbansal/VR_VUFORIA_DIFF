using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RotateCube : MonoBehaviour
{
    public GameObject cube1;
    //public RectTransform rectTransform;
    public TMP_Text genralText;
    public TMP_Text languageText;
    public TMP_Text frontEndText;
    public TMP_Text dataBaseText;
    void Start()
    {
         setFalseAll();
    }
    public void OnRightClick()
    {
        //Cube.transform.rotation=Quaternion.Euler(0.0f,Cube.transform.rotation.y+90.0f,0.0f);
    }
    public void OnLeftClick()
    {
        //Cube.transform.rotation=Quaternion.Euler(0.0f,Cube.transform.rotation.y-90.0f,0.0f);
    }
    public void showGenralText()
    {
        setFalseAll();
        genralText.gameObject.SetActive(true);
    }
    public void showlanguageText()
    {
        setFalseAll();
        languageText.gameObject.SetActive(true);
    }
    public void showfrontEndText()
    {
        setFalseAll();
        frontEndText.gameObject.SetActive(true);
    }
    public void showdataBaseText()
    {
        setFalseAll();
        dataBaseText.gameObject.SetActive(true);
    }
    public void setFalseAll()
    {
        genralText.gameObject.SetActive(false);
        languageText.gameObject.SetActive(false);
        frontEndText.gameObject.SetActive(false);
        dataBaseText.gameObject.SetActive(false);
    }
    void Update()
    {
        //Vector2 pos = cube1.transform.position;  
        //Vector2 viewportPoint = Camera.main.WorldToViewportPoint(pos); 
        //rectTransform.anchorMin = viewportPoint;  
        //rectTransform.anchorMax = viewportPoint; 
    }
}
