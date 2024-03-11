using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CreateTxt : MonoBehaviour
{
    public string fileName = "";

    [HideInInspector]
    public string path;

    // Start is called before the first frame update
    void Start()
    {
        path = Path.Combine(Application.persistentDataPath, fileName, ".txt");
        Debug.Log(path);
        File.CreateText(path);
    }

}
