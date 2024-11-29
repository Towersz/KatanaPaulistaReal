using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss : MonoBehaviour
{
    [SerializeField] private BoxCollider2D BoxCollider2D;
    [SerializeField] private Animator animator;

    void transformation()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.animator.SetBool("Elesetranformou?", true);
    }
}
