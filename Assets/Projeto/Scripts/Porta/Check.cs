using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    [SerializeField] private bool Aberto;
    [SerializeField] private Animator animator;
    [SerializeField] private BoxCollider2D BoxCollider2D;

    void FixedUpdate()
    {
        Abrir();
    }
    void Abrir()
    {
        if (Aberto == true)
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
    private void OnTriggerEnter2D()
    {
        Aberto = true;
    }
    private void OnTriggerExit2D()
    {
        Aberto = false;
    }
}
