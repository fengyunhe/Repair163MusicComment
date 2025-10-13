using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var textCmp = this.GetComponent<Text>();
        textCmp.text = textCmp.text + "v" + Application.version;
    }
 
}
