using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_ImageToggle : MonoBehaviour
{
    public RawImage image;
    public ManagerTaskAndData manager;
    public bool isChecked = false;
    void Start()
    {
        image.color = Color.clear;
    }
    
    public void Found()
    {
        image.color= Color.red;
        if (isChecked == false)
        {
            isChecked = true;
            manager.TaskCounterIncrease();
        }
        return;
    }
}
