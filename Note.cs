using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// UPDATED 
// The text value in this script can now be accessed in other places with ease.
public class Note : MonoBehaviour
{
    [Header("WRITE ANY ADDITIONAL INFORMATION HERE")]
    [TextAreaAttribute]
    [SerializeField] private string _text;
    
    public string Text 
    {
        get 
        {
           return _text;
        }
        set 
        {
            _text = value;
        }
    }

}
