using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Correct_Choice_Checker : MonoBehaviour
{
    public ManagerTaskAndData manager;
    public Dropdown SelectedOptionValue;
    public int TheCorrectValue = 1;
    public bool CheckValueSelected = false;

    public void Start()
    {
        SelectedValueCheck();
    }

    public void SelectedValueCheck()
    {
        if (SelectedOptionValue.value == TheCorrectValue)
        {
            if (CheckValueSelected == false)
            {
                CheckValueSelected = true;
                manager.HiddenTaskCounterIncrease();
                return;
            }
            else
            {
                return;
            }
        }
        else
        {
            if (CheckValueSelected == true)
            {
                CheckValueSelected = false;
                manager.HiddenTaskCounterDecrease();
                return;
            }
            else 
            {
                return;
            }
        }
    }
}
