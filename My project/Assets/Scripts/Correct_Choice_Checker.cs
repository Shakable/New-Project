using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Correct_Choice_Checker : MonoBehaviour
{
    [Header("Parts")]
    public ManagerTaskAndData manager;
    public Dropdown SelectedOptionValue;
    public int TheCorrectValue = 1;
    public bool MultiCorrect = false;
    public int TheCorrectValue2nd = 2;
    public int TheCorrectValue3rd = 3;
    public int TheCorrectValue4th = 4;
    public int TheCorrectValue5th = 5;

    [Header("Override")]
    public Text OverrideText_Awnser1 = null;
    public Text OverrideText_Awnser2 = null;
    public Text OverrideText_Awnser3 = null;
    public Text OverrideText_Awnser4 = null;
    public Text OverrideText_Awnser5 = null;

    [Header("Don't touch")]
    public bool CheckValueSelected = false;

    public void Start()
    {
        int defaultvalue = SelectedOptionValue.value;
        if (OverrideText_Awnser1 != null)
        {
            SelectedOptionValue.value = 1;
            SelectedOptionValue.captionText = OverrideText_Awnser1;
            SelectedOptionValue.value = defaultvalue;
        }
        if (OverrideText_Awnser2 != null)
        {
            SelectedOptionValue.value = 2;
            SelectedOptionValue.captionText = OverrideText_Awnser2;
            SelectedOptionValue.value = defaultvalue;
        }
        if (OverrideText_Awnser3 != null)
        {
            SelectedOptionValue.value = 3;
            SelectedOptionValue.captionText = OverrideText_Awnser3;
            SelectedOptionValue.value = defaultvalue;
        }
        if (OverrideText_Awnser4 != null)
        {
            SelectedOptionValue.value = 4;
            SelectedOptionValue.captionText = OverrideText_Awnser4;
            SelectedOptionValue.value = defaultvalue;
        }
        if (OverrideText_Awnser5 != null)
        {
            SelectedOptionValue.value = 5;
            SelectedOptionValue.captionText = OverrideText_Awnser5;
            SelectedOptionValue.value = defaultvalue;
        }
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
        else if (SelectedOptionValue.value == TheCorrectValue2nd && MultiCorrect == true)
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
        else if (SelectedOptionValue.value == TheCorrectValue3rd && MultiCorrect == true)
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
        else if (SelectedOptionValue.value == TheCorrectValue4th && MultiCorrect == true)
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
        else if (SelectedOptionValue.value == TheCorrectValue5th && MultiCorrect == true)
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
