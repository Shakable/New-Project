using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test_TaskManualIncrease : MonoBehaviour
{
    public ManagerTaskAndData manager;
    public void TestingTaskCounterIncrease()
    {
        manager.TaskCounterIncrease();
    }

}
