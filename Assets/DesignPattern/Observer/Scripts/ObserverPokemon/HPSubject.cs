using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPSubject : MonoBehaviour, IPSubject
{
    private List<IPObserver> m_PObservers = new List<IPObserver>();

    private float m_HP;
    private float enemy_HP;

    public Slider myHPBar;
    public Slider enemyHPBar;

    private float atk = 10f;

    public void SetHP(float m_hp, float e_hp)
    {
        m_HP = m_hp;
        enemy_HP = e_hp;
        Notify();
    }

    private void Start()
    {
        m_HP = 100f;
        enemy_HP = 100f;

        var myObserver = gameObject.GetComponent<PMyHPObserver>();
        var enemyObserver = gameObject.GetComponent<PEnemyHPObserver>();

        Register(myObserver);
        Register(enemyObserver);
    }

    public void Notify()
    {
        foreach (var pokemon in m_PObservers)
        {
            pokemon.PObserverUpdate(m_HP, enemy_HP);
        }
    }

    public void Attack()
    {
        m_HP -= atk;
        enemy_HP -= atk;
        Notify();
    }

    public void Register(IPObserver observer)
    {
        m_PObservers.Add(observer);
    }

    public void Remove(IPObserver observer)
    {
        if (m_PObservers.IndexOf(observer) > 0)
            m_PObservers.Remove(observer);
    }

}
