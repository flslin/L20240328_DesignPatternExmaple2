using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // ���� ���� ��� Ŭ������ �ʵ� ������ ����
    WeaponSelector weaponSelector;

    private void Start()
    {
        weaponSelector = new WeaponSelector();
        // ���� ���� Ŭ������ ����� ���� �������̽��� ������ Ŭ������ Ȱ��
        weaponSelector.SetWeapon(new Bullet());
    }

    // ���� ���� Ŭ������ ��ɵ��� ���� �������̽��� ������ Ŭ������ ���� ������ ����
    public void ChangeBullte() => weaponSelector.SetWeapon(new Bullet());

    public void ChangeSword() => weaponSelector.SetWeapon(new Sword());

    public void ChangeArrow() => weaponSelector.SetWeapon(new Arrow());

    public void OnFire() => weaponSelector.Attack();
}
