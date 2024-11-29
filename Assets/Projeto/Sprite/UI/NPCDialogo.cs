using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogo : MonoBehaviour
{
    public Sprite Profile;
    public string[] SpeechText;
    public string TextName;

    public LayerMask LayerMask;
    public float Radius;
    private bool OnRadios;

    private DialogoControle Dc;

    private void Start()
    {
        Dc = FindObjectOfType<DialogoControle>();
    }

    private void Update()
    {
        Interect();
        if (Input.GetKeyDown(KeyCode.F) && OnRadios)
        {
            Dc.Speech(Profile, SpeechText, TextName);
        }
    }
    public void Interect()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, Radius, LayerMask);

        if (hit != null)
        {
            OnRadios = true;
        }
        else
        {
            OnRadios = false;
        }
    }



}
