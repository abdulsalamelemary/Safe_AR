using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public TextMeshProUGUI LangBTNText;
    public bool bArabic;

    public AudioSource ArabicSource, EnglishSource;

    // Start is called before the first frame update
    void Start()
    {
        SetLanguage(bArabic);
    }

    public void OnLanguageBTNClicked()
    {
        bArabic = !bArabic;
        SetLanguage(bArabic);
    }

    public void SetLanguage(bool _bArabic)
    {
        if (_bArabic)
        {
            LangBTNText.text = "AR";
            ArabicSource.volume = 1;
            EnglishSource.volume = 0;
        }
        else
        {
            LangBTNText.text = "EN";
            ArabicSource.volume = 0;
            EnglishSource.volume = 1;
        }
    }

}// End class Language Manager
