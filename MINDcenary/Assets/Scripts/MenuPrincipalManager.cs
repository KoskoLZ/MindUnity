using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;
using FMOD.Studio;
using UnityEngine.UI;

public class MenuPrincipalManager : MonoBehaviour
{

FadeInOut fade;
[SerializeField] private string level1;
[SerializeField] private GameObject Menuprincipal;
[SerializeField] private GameObject painelOpcoes;

void Start()
{
    fade = FindAnyObjectByType<FadeInOut>();
}

public IEnumerator ChangeScene()
{
    fade.FadeIn();
    yield return new WaitForSeconds(1);
    SceneManager.LoadScene(level1);
}

public void Jogar()
{
    StartCoroutine(ChangeScene());
}

public void AbrirOpcoes()
{
 Menuprincipal.SetActive(false);
 painelOpcoes.SetActive(true);
}

public void FecharOpcoes()
{
 Menuprincipal.SetActive(true);
 painelOpcoes.SetActive(false);
}

    
public void SairJogo()
{
    Application.Quit();
    Debug.Log("Sair Do Jogo");
    #if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
}

}
