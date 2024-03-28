using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class Observer1 : Observer
{
    public override void OnNotify()
    {
        Debug.Log("Observer2 실행");
    }
}

