using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class MonoSubject : MonoBehaviour, Subject
{
    List<Observer> observers = new List<Observer>(); // 옵저버들을 관리하는 List

    private void Start()
    {
        var observer1 = new Observer1();
        var observer2 = new Observer2();

        Subscribe(observer1);
        Subscribe(observer2);
    }

    /// <summary>
    /// 관리중인 옵저버들에게 연락을 하는 기능을 가진 메소드
    /// </summary>
    public void Notify()
    {
        foreach(Observer observer in observers)
        {
            observer.OnNotify();
        }
    }

    public void Subscribe(Observer observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(Observer observer)
    {
        if (observers.IndexOf(observer) > 0)
            observers.Remove(observer);
    }
}

