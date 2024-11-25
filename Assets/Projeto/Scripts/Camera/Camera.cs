using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform alvo;

    [SerializeField] private float acelera��oCamera;
    
    private void Start()
    {

        
    }
    void Update()
    {
        Vector3 posi��oFinal = this.alvo.position;
        posi��oFinal.z = this.transform.position.z;
        posi��oFinal.y = this.transform.position.y;
        
        posi��oFinal = Vector3.Lerp(this.transform.position, posi��oFinal, this.acelera��oCamera * Time.deltaTime);

        this.transform.position = posi��oFinal;
    }
}
