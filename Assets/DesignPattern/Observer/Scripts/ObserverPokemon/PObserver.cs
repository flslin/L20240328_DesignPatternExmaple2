using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPObserver
{
    // ������ �����ϰ� �ʱ�ȭ�ϴ� ���
    // ������ ü�°� ���� ü�� �ۼ�
    void PObserverUpdate(float myHP, float enemyHP);
}
