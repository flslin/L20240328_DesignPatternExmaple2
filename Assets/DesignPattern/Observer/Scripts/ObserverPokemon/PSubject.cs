using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPSubject
{
    void Register(IPObserver observer);
    void Remove(IPObserver observer);
    void Notify();
}
