using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UIElements;


public class TimeTracker : MonoBehaviour
{
    public GameObject infoPanel;
    public int panelNum;
    public CreateTxt TextFileCreator;

    private DateTime start;
    private DateTime end;

    

    // Update is called once per frame
    void Update()
    {
        

        if (infoPanel.activeSelf == true)
        {
            start = DateTime.Now;
        }

        if (infoPanel.activeSelf == false) 
        {
            end = DateTime.Now;
            var diffSec = (end - start).TotalMilliseconds;

            File.AppendAllText(TextFileCreator.path, "panel" + panelNum.ToString() + ", " + diffSec.ToString());
            
        }
    }
}
