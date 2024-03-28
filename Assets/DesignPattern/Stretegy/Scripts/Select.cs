using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum langType { KO, EN}

public class Select : MonoBehaviour
{
    private ILanguage iLang;

    public Text explane;
    public Button EN;
    public Button KO;

    public Button select;

    private void ChangeLangauge(langType type)
    {
        switch (type)
        {
            case langType.KO:
                iLang = gameObject.AddComponent<Korean>();
                ChangeKorean();
                break;
            case langType.EN:
                iLang = gameObject.AddComponent<English>();
                ChangeEnglish();
                break;
            default:
                iLang = gameObject.AddComponent<Korean>();
                ChangeKorean();
                break;
        }
    }

    public void ChangeKorean() => ChangeLangauge(langType.KO);
    public void ChangeEnglish() => ChangeLangauge(langType.EN);
}
