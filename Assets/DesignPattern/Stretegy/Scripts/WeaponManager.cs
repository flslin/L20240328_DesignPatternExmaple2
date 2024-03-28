using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // 무기 선택 기능 클래스르 필드 값으로 가짐
    WeaponSelector weaponSelector;

    private void Start()
    {
        weaponSelector = new WeaponSelector();
        // 무기 선택 클래스의 기능을 통해 인터페이스로 구현한 클래스를 활용
        weaponSelector.SetWeapon(new Bullet());
    }

    // 무기 선택 클래스의 기능들을 통해 인터페이스로 구현한 클래스에 대한 설정을 변경
    public void ChangeBullte() => weaponSelector.SetWeapon(new Bullet());

    public void ChangeSword() => weaponSelector.SetWeapon(new Sword());

    public void ChangeArrow() => weaponSelector.SetWeapon(new Arrow());

    public void OnFire() => weaponSelector.Attack();
}
