﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class Observer1 : Observer
{
    GameObject obj;

    public Observer1(GameObject obj)
    {
        this.obj = obj;
    }

    public override void OnNotify(int number)
    {
        int value = obj.gameObject.GetComponent<MonoSubject>().GetNumber();

        Debug.Log("Observer1 실행");
        Debug.Log("오브젝트를 통해 얻어 온 값 : " + value);
        Debug.Log("매개변수 값 : " + number);
    }
}

