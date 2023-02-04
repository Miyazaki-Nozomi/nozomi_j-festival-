using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static UnityEngine.Networking.UnityWebRequest;

public class DateTimetest : MonoBehaviour
{
    DateTime _dt = default;
    
    void Start()
    {
        _dt = DateTime.Now;
        Debug.Log(_dt);
        string result = _dt.ToString("yyyy/MM/dd HH:mm:ss");
        Debug.Log(result);
    }
    void Update()
    {
        
    }
}
