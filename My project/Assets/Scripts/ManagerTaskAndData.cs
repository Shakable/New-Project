using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTaskAndData : MonoBehaviour
{
    public int TaskCounter_Done = 0;
    public int TaskCounter_Needed = 3;
    int HiddenTaskCounter_Done = 0;
    public NextPage NextPage;
    public TaskCounterText_Changer TaskCounterText_Changer;

    public void Start()
    {
        TaskCounterText_Changer.RefreshCounter();
    }
    public void TaskCheck()
    {
        if ((TaskCounter_Done + HiddenTaskCounter_Done) >= TaskCounter_Needed) 
        {
            NextPage.TaskComplete = true;
        }
        else
        {
            NextPage.TaskComplete = false;
        }

        TaskCounterText_Changer.TrueRefresh(HiddenTaskCounter_Done);
        return;
    }

    public void TaskCounterIncrease()
    {
        TaskCounter_Done = TaskCounter_Done + 1;
        TaskCounterText_Changer.RefreshCounter();
    }
    public void TaskCounterDecrease()
    {
        TaskCounter_Done = TaskCounter_Done - 1;
        TaskCounterText_Changer.RefreshCounter();
    }
    public void HiddenTaskCounterIncrease()
    {
        HiddenTaskCounter_Done = HiddenTaskCounter_Done + 1;
    }
    public void HiddenTaskCounterDecrease()
    {
        HiddenTaskCounter_Done = HiddenTaskCounter_Done - 1;
    }
}
