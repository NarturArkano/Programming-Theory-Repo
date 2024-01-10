using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField nameField;
    [SerializeField] TMP_Dropdown animalChooser;

    // Start is called before the first frame update
    public void StartNew()
    {
        string animalName = nameField.GetComponent<TMP_InputField>().text;
        if (!String.IsNullOrWhiteSpace(animalName) && animalName.Length <= 10) {
            DataHandler.Instance.setName(animalName);
            DataHandler.Instance.setType(animalChooser.GetComponent<TMP_Dropdown>().value);
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("Name empty or too long");
        }
    }
}
