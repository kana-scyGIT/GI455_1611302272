using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputScript : MonoBehaviour
{
    // Start is called before the first frame update
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
