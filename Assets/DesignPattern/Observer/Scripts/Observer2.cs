using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

internal class Observer2 : Observer
{
    public override void OnNotify()
    {
        Debug.Log("Observer1 실행");
    }
}

