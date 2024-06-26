using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    // 대상, 주체를 의미하는 인터페이스. 옵저버에 대한 관리와 활용 관련 코드를 가짐

    void Subscribe(Observer observer);
    void Unsubscribe(Observer observer);
    void Notify();
}
