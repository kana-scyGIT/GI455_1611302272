using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findingScript : MonoBehaviour
{
    // Start is called before the first frame update

    private string targetText;
    public Text resultText;
    
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Find()
    {
        targetText = searchScript.inputText;
        Debug.Log(targetText);
        Compare();
    }

    void Compare()
    {
        switch (targetText)
        {
            case "Unity" :
                resultText.text = "Unity Found";
                break;
            case "Maya3D" : print(("Found Maya"));
                break;
            default: print(targetText+" not Found ");
                break;
        }
    }
    
    
    
}

