using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class English : MonoBehaviour, ILanguage
{
    public void ChangeLanguage(Text text)
    {

        text.text = "Language : English\n\n" +
        "Player Name : XXX\n" +
        "Player Level : 1";
    }
}
