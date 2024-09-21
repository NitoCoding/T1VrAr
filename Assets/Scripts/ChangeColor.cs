using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeColor : MonoBehaviour
{
    public void Red()
    {
        Debug.Log("Red method called"); // Log message to check if the method is called
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void RandomColor()
    {
        Debug.Log("RandomColor() called");
        Color randomColor = new Color(
            Random.Range(0f, 1f), // Red component
            Random.Range(0f, 1f), // Green component
            Random.Range(0f, 1f)  // Blue component
        );
        GetComponent<Renderer>().material.color = randomColor;
    }

}