using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

//���� �ý��� �ð��� �����ִ� Ŭ����
public class ClockUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH : mm");
    }
}
