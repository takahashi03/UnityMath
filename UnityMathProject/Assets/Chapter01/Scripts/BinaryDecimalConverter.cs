using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BinaryDecimalConverter : MonoBehaviour
{
    [SerializeField]
    private InputField inputBinary;    
    private int binary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void InputBinary()
    {
        binary = int.Parse(inputBinary.text);
        Debug.Log(binary);
    }

    private void InputBinaryException()
    {

    }
}
