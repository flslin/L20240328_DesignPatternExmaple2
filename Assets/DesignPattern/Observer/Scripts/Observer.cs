using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer // public interface Observer �ε� ����
{
    // �������� ���� �߻� Ŭ����. ���������� �����ؾ��� ��ɵ��� ������� (�������̽��� ����)

    public abstract void OnNotify(int number);
}
