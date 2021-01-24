using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textUpdate : MonoBehaviour
{
    // Start is called before the first frame update
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
        targetText = inputScript.inputText;
        Debug.Log(targetText);
        Compare();
    }

    void Compare()
    {
        switch (targetText)
        {
            
            case "Kan" :
                TextFound();
                break;
            
            
            case "1611302272" :                 
                TextFound();
                break;
            
            case "Ubisoft" :                 
                TextFound();
                break;
            
            case "Square Enix" :
                TextFound();
                break;
            
            case "EA" :
                TextFound();
                break;
            
            
            
            default:
                TextnotFound();
                break;
        }
    }

    void TextFound()
    {
        resultText.text = "[ " + targetText +" ] is Found";
        resultText.color = Color.green;
    }

    void TextnotFound()
    {
        resultText.text = "[ " + targetText +" ] is not Found";
        resultText.color = Color.red;
    }
}
