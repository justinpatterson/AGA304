using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot = default, minutesPivot, secondsPivot;

    float hoursToDegrees = -30f;
    float secondsToDegrees = -6f;
    float minutesToDegrees = -6f;


    private void Awake()
    {
        hoursPivot.rotation = Quaternion.Euler(0, 0, hoursToDegrees * DateTime.Now.Hour);
        minutesPivot.rotation = Quaternion.Euler(0, 0, minutesToDegrees * DateTime.Now.Minute);
        secondsPivot.rotation = Quaternion.Euler(0, 0, secondsToDegrees * DateTime.Now.Second);
    }

    private void Update()
    {
        DateTime time = DateTime.Now;
        hoursPivot.rotation = Quaternion.Euler(0, 0, hoursToDegrees * time.Hour);
        minutesPivot.rotation = Quaternion.Euler(0, 0, minutesToDegrees * time.Minute);
        secondsPivot.rotation = Quaternion.Euler(0, 0, secondsToDegrees * time.Second);
    }
}
