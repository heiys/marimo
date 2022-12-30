using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestButton : BaseButton
{
    override protected void OnClick()
    {
        // Debug.Log("Button Clicked");
        float x = Random.Range(-1.0f, 1.0f);
        float y = Random.Range(-1.0f, 1.0f);
        GameObject marimo = GameObject.Find("slime_01");
        Vector3 movePoint = new(x, y);
        
        Unit unit = marimo.GetComponent<Unit>();
        unit.Move(movePoint);
    }
}
