using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskCounterText_Changer : MonoBehaviour
{
    public ManagerTaskAndData manager;
    public Text taskCounterText;
    int taskCounter_extra = 0;
    public void RefreshCounter()
    {
        taskCounterText.text = (manager.TaskCounter_Done + taskCounter_extra).ToString() + "/" + manager.TaskCounter_Needed.ToString();
        return;
    }
    public void TrueRefresh(int secret_count)
    {
        taskCounter_extra = secret_count;
        RefreshCounter();
    }
}
