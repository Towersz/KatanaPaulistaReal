using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] private string Nomedoleveldejogo;
    [SerializeField] private GameObject painelMenu;
    [SerializeField] private GameObject painelOp��es;
    [SerializeField] private GameObject painelCreditos;
    public void Abrir()
    {
        SceneManager.LoadScene(Nomedoleveldejogo);
    }
    public void abrirOpcoes()
    {
        painelMenu.SetActive(false);
        painelOp��es.SetActive(true);
    }
    public void fecharOpcoes()
    {
        painelOp��es.SetActive(false);
        painelMenu.SetActive(true);
    }
    public void abrirCreditos()
    {
        painelMenu.SetActive(false);
        painelCreditos.SetActive(true);
    }
    public void fecharCreditos()
    {
        painelCreditos.SetActive(false);
        painelMenu.SetActive(true);
    }
    public void Sair()
    {
        Debug.Log("Sair");
        Application.Quit();
    }
}
