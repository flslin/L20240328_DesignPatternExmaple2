using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PEnemyHPObserver : MonoBehaviour, IPObserver
{
    public Slider enemyHPBar;
    HPSubject enemyHPSubject;

    //GameObject obj;

    //public PEnemyHPObserver(GameObject obj)
    //{
    //    this.obj = obj;
    //}

    public void PObserverUpdate(float myHP, float enemyHP)
    {
        //gameObject.GetComponent<HPSubject>().SetHP(myHP, enemyHP);
        enemyHPBar.value = enemyHP;
        Debug.Log("EEVEE Attack!");
        Debug.Log(enemyHPBar.value);
    }
}
