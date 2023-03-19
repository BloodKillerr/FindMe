using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class SaveDropdown : MonoBehaviour
{
    public string PrefName;
    public TMP_Dropdown resDropdown;

    void Awake()
    {
        resDropdown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt(PrefName, resDropdown.value);
            PlayerPrefs.Save();
        }));
    }

    void Start()
    {
        resDropdown.value = PlayerPrefs.GetInt(PrefName, 0);
    }

}
