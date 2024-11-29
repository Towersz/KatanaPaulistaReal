using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroina : MonoBehaviour
{
    public float SpeedUp = 0.5f;
    public float SpeedUpDur = 5f;
    public int AmountToGive;
    

    private Anarquista player;
    private void Awake()
    {
        player = FindObjectOfType<Anarquista>();
    }

    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.SendMessage("Droga",1);
            Debug.Log("colidiu"+ collision.gameObject.name);
            collision.gameObject.SendMessage("SetTimeScaleItem", new float[] { SpeedUp, SpeedUpDur });
            FindObjectOfType<AudioManager>().Play("Item III");


            Destroy(gameObject);

        }

        
    }


}



