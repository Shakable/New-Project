using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class NextPage : MonoBehaviour
{
    public bool TaskComplete = false;
    public ManagerTaskAndData manager;
    public void MoveNextPage_Information()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MoveNextPage_TaskCheck()
    {
        manager.TaskCheck();
        if (TaskComplete == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            EditorUtility.DisplayDialog("Incomplete Tasks", "You have not completed all the tasks in this page.","Alrighty");
            return;
        }
    }
}
