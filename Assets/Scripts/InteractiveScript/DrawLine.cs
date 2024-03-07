using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public LineRenderer myLineRenender;
    public GameObject firstObject;
    public GameObject secondObject;

    // Start is called before the first frame update
    void Start()
    {
        myLineRenender.positionCount = 2;

        myLineRenender.SetPosition(0, firstObject.transform.position);
        myLineRenender.SetPosition(1, secondObject.transform.position);


    }

    // Update is called once per frame
    void Update()
    {
        myLineRenender.SetPosition(0, firstObject.transform.position);
        myLineRenender.SetPosition(1, secondObject.transform.position);
    }
}
