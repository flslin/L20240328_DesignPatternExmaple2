using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PMyHPObserver : MonoBehaviour, IPObserver
{
    public Slider myHPBar;
    HPSubject myHPSubject;

    //GameObject obj;

    //public PMyHPObserver(GameObject obj)
    //{
    //    this.obj = obj;
    //}

    public void PObserverUpdate(float myHP, float enemyHP)
    {
        //gameObject.GetComponent<HPSubject>().SetHP(myHP, enemyHP);
        myHPBar.value = myHP;
        Debug.Log("PIKACHU Attack!");
        Debug.Log(myHPBar.value);
    }

}
