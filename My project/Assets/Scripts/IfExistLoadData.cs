using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfExistLoadData : MonoBehaviour
{
    public string StorageObjectName = "StorageObject";
    public Text ObjectLoadText = null;
    public string InnerTextHolder = null;
    Text LoadableText = null;

    void Start()
    {
        if (GameObject.Find(StorageObjectName) != null)
        {
            LoadableText = GameObject.Find(StorageObjectName).GetComponent<Text>();
            InnerTextHolder = LoadableText.text;
            if (ObjectLoadText != null)
            {
                ObjectLoadText.text = LoadableText.text;
            }
        }
    }
}
