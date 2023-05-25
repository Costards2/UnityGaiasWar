using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelCreditos;
    [SerializeField] private GameObject painelHistoria;
    [SerializeField] private AudioSource volumeMenu;

    public void Jogar()
    {
        SceneManager.LoadScene("Game_1");
    }

    public void Opcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void VoltarOpcoes()
    {
        painelMenuInicial.SetActive(true);
        painelOpcoes.SetActive(false);
    }

    public void Creditos()
    {
        painelMenuInicial.SetActive(false);
        painelCreditos.SetActive(true);
    }

    public void VoltarCreditos()
    {
        painelMenuInicial.SetActive(true);
        painelCreditos.SetActive(false);
    }

    public void Historia()
    {
        painelMenuInicial.SetActive(false);
        painelHistoria.SetActive(true);
    }

    public void VoltarHistoria()
    {
        painelMenuInicial.SetActive(true);
        painelHistoria.SetActive(false);
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Sair()
    {
        Debug.Log("Sair");
        Application.Quit();
    }

}
