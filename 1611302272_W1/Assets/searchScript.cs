using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class searchScript : MonoBehaviour
{
    public InputField textField;
    public static string inputText;


    void Start()
    {

    }

    void Update()
    {
        inputText = textField.text;
    }
    
    
}
