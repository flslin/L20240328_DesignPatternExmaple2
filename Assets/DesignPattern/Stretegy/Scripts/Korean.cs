using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class Korean : MonoBehaviour, ILanguage
{
    public void ChangeLanguage(Text text)
    {

        text.text = "��� : �ѱ���\n\n" +
                "�÷��̾� �̸� : XXX\n" +
                "�÷��̾� ���� : 1";
    }
}
