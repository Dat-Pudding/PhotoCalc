using System;
using UnityEngine;

public class OutputManagerMobile : MonoBehaviour
{
    public double timeStamp;
    public double secondTimeStamp;

    public double usedTime;

    void Start()
    {
        timeStamp = 0f;
    }

    private void Update()
    {
        secondTimeStamp = Time.timeAsDouble;
    }

    public void SetTimeStamp()
    {
        timeStamp = Time.timeAsDouble;
    }

    public void GetTimeDiff()
    {
        //secondTimeStamp = Time.timeAsDouble;
        usedTime = Math.Round(timeStamp - secondTimeStamp, 3);
    }
}