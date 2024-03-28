using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPObserver
{
    // 정보를 갱신하고 초기화하는 기능
    // 본인의 체력과 적의 체력 작성
    void PObserverUpdate(float myHP, float enemyHP);
}
