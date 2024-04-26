using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inserted_Value_Checker : MonoBehaviour
{
    public InputField InputStringValue;
    public bool CheckTextInserted = false;
    public ManagerTaskAndData manager;

    public void TextChangeCheck()
    {
        string InputedText = InputStringValue.text;
        if (!string.IsNullOrEmpty(InputedText))
        {
            if (CheckTextInserted ==  false)
            {
                CheckTextInserted = true;
                manager.TaskCounterIncrease();
                return;
            }
            else
            {
                return;
            }
        }
        else
        {
            if (CheckTextInserted == true)
            {
                CheckTextInserted = false;
                manager.TaskCounterDecrease();
            }
            else
            {
                return;
            }
        }
    }
}
