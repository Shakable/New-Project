using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_ManualTaskCheck : MonoBehaviour
{
    public ManagerTaskAndData manager;
    public void TaskRefesh()
    {
        manager.TaskCheck();
    }
}
