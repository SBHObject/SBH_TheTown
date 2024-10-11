using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

//현재 시스템 시간을 보여주는 클래스
public class ClockUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH : mm");
    }
}
