using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Distance : MonoBehaviour
{
    private GameObject[] EndsList;
    private int EndsNum;

    public GameObject DistanceText;

    public LineRenderer line;

    // Update is called once per frame
    void Update()
    {
        EndsList = GameObject.FindGameObjectsWithTag("RulerEnd");
        EndsNum = EndsList.Length;

        if (EndsNum!=2)
        {
            return;
        }
        else
        {
            //オブジェクト間の距離を表示
            float distance = Vector3.Distance(EndsList[0].transform.position, EndsList[1].transform.position);
            Text distance_text = DistanceText.GetComponent<Text>();
            distance_text.text = distance.ToString();

            //オブジェクト同士を線でつなぐ
            //LineRenderer line = GameObject.Find("LineRendererObject").GetComponent<LineRenderer>();
            line.SetPosition(0, EndsList[0].transform.position);
            line.SetPosition(1, EndsList[1].transform.position);
        }
    }
}