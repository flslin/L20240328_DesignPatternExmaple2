using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class Korean : MonoBehaviour, ILanguage
{
    public void ChangeLanguage(Text text)
    {

        text.text = "언어 : 한국어\n\n" +
                "플레이어 이름 : XXX\n" +
                "플레이어 레벨 : 1";
    }
}
