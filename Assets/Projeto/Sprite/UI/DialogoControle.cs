using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoControle : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogo;
    public Image Profile;
    public Text SpeechText;
    public Text TextName;

    [Header("Config")]
    public float SpeedText;
    private string[] Sentences;
    private int index;


    public void Speech(Sprite Imagem, string[] Txt, string Name)
    {
        dialogo.SetActive(true);
        Profile.sprite = Imagem;
        Sentences = Txt;
        TextName.text = Name;
        StartCoroutine(TypeSentences());
    }
    IEnumerator TypeSentences()
    {
        foreach (char letter in Sentences[index].ToCharArray())
        {
            SpeechText.text += letter;
            yield return new WaitForSeconds(SpeedText);
        }
    }
    public void Proximafrase()
    {
        if (SpeechText.text == Sentences[index])
        {
            if(index < Sentences.Length - 1)
            {
                index++;
                SpeechText.text = "";
                StartCoroutine (TypeSentences());
            }
            else
            {
                SpeechText.text = "";
                index = 0;
                dialogo.SetActive (false);
            }
        }
    }
}
