using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class AnimaçãoTexto : MonoBehaviour
{
    public float typeDelay = 0.05f;
    public TextMeshProUGUI textObject;

    public string FullText;
    void Start()
    {
        StartCoroutine(typeText());
    }
    IEnumerator typeText()
    {
        textObject.text = FullText;
        textObject.maxVisibleCharacters = 0;
        for(int I = 0; 1<= textObject.text.Length; I++)
        {
            textObject.maxVisibleCharacters = I;
            yield return new WaitForSeconds(typeDelay);
        }
    }

}
