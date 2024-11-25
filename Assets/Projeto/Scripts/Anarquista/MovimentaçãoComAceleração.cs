using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NovaMovimenta��o : MonoBehaviour
{
    [SerializeField] private float acelera��o;
    [SerializeField] private float Freiar;
    [SerializeField] private float VelMaxima;

    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private Vector2 movimento = Vector2.zero;


    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        movimento = new Vector2(horizontalInput, verticalInput).normalized;
    }
    private void FixedUpdate()
    {
        Acelera��o();
    }

    private void Acelera��o()
    {
        if (movimento != Vector2.zero)
        {
            // Calcular a velocidade atual  
            Vector2 currentVelocity = rig.velocity;

            // Calcular a velocidade alvo com acelera��o  
            Vector2 targetVelocity = movimento * VelMaxima;

            // Calcular a mudan�a na velocidade  
            Vector2 deltaVelocity = targetVelocity - currentVelocity;

            // Aplicar acelera��o ou desacelera��o  
            Vector2 accelerationVector = deltaVelocity.normalized * (acelera��o * Time.fixedDeltaTime);

            // Limitar a acelera��o para que n�o exceda a acelera��o m�xima  
            if (accelerationVector.sqrMagnitude > deltaVelocity.sqrMagnitude)
            {
                accelerationVector = deltaVelocity;
                
            }

            // Atualizar a velocidade  
            rig.velocity += accelerationVector;

            // Limitar a velocidade � velocidade m�xima  
            rig.velocity = Vector2.ClampMagnitude(rig.velocity, VelMaxima);

            if (VelMaxima > 0)
            {
                this.animator.SetBool("Andando", true);
                this.spriteRenderer.flipX = false;
                
            }
            else if (VelMaxima < 0)
            {
                this.spriteRenderer.flipX = true;
            }
            if (VelMaxima > 10)
            {
                this.animator.SetBool("Correndo", true);
                this.animator.SetBool("Andando", false);
            }
            else if (VelMaxima < 10)
            {
                this.animator.SetBool("Correndo", false);
            }
            
        }
        else
        {
            // Se n�o houver entrada, desacelerar para parar  
            Vector2 decelerationVector = -rig.velocity.normalized * (Freiar * Time.fixedDeltaTime);
            rig.velocity += decelerationVector;

            // Garantir que a velocidade n�o fique abaixo de zero  
            if (Vector2.Dot(rig.velocity + decelerationVector, decelerationVector) > 0f)
            {
                rig.velocity = Vector2.zero;

                this.animator.SetBool("Andando", false);
                this.animator.SetBool("Correndo", false);
            }
        }
    }
}
