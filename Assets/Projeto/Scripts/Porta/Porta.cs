using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Porta : MonoBehaviour
{
    [SerializeField] private float tamanhoCubo;
    [SerializeField] private bool Aberto = false;
    [SerializeField] private Animator animator;
    [SerializeField] private BoxCollider2D BoxCollider2D;
    void Update()
    {
        Abrir();
    }
    void Abrir()
    {
        if(Aberto == true)
        {
            this.animator.SetBool("Abrido", true);
            FindObjectOfType<AudioManager>().Play("PortaAberta");
            this.BoxCollider2D.enabled = false;
        }
        else if (Aberto == false)
        {
            this.animator.SetBool("Abrido", false);
            FindObjectOfType<AudioManager>().Play("PortaFec");
            this.BoxCollider2D.enabled = true;
        }
    }
}
