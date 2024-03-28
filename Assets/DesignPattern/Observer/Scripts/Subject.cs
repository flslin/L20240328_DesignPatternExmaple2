using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Subject
{
    // ���, ��ü�� �ǹ��ϴ� �������̽�. �������� ���� ������ Ȱ�� ���� �ڵ带 ����

    void Subscribe(Observer observer);
    void Unsubscribe(Observer observer);
    void Notify();
}
