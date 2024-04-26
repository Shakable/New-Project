using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class LastPage : MonoBehaviour
{
    public void MoveLastPage_Information()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void MoveLastPage_TaskExit()
    {   
        if (EditorUtility.DisplayDialog("Going back","You sure you want to leave this task? The task progress won't be saved.", "Yes, I will", "Nevermind") == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            return;
        }
    }
}
