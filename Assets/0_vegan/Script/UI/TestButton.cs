using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestButton : CommonButton
{
    override protected void OnClick()
    {
        Debug.Log("Button Clicked");
        float x = Random.Range(-1.0f, 1.0f);
        float y = Random.Range(-1.0f, 1.0f);
        GameObject marimo = GameObject.Find("Marimo");
        Vector3 movePoint = new(x, y);
        marimo.transform.position = movePoint;
    }
}
