using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float loadSceneDelay = 1f;
    int indexScrene;
    public void LoadMainMenu() {
        SceneManager.LoadScene("Main Menu");
    }
    public void LoadGame() {
        SceneManager.LoadScene("Fly Over");
    }
    public void LoadGameOver() {
        ScoreManager.ResetScore();
        StartCoroutine(WaitAndLoad("EndMenu", loadSceneDelay));
    }
    IEnumerator WaitAndLoad(string sceneName, float delay) {
        ScoreManager.ResetScore();
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
    public void LoadMenuLV()
    {
        SceneManager.LoadScene(15);
    }
    public void LoadLevel_1()
    {
        ScoreManager.ResetScore();
        SceneManager.LoadScene(3);
    }
    public void LoadLevel_2()
    {
        ScoreManager.ResetScore();
        SceneManager.LoadScene(5);
    }
    public void LoadLevel_3()
    {
        ScoreManager.ResetScore();
        SceneManager.LoadScene(7);
    }
    public void LoadLevel_4()
    {
        ScoreManager.ResetScore();
        SceneManager.LoadScene(9);
    }
    public void LoadLevel_5()
    {
        ScoreManager.ResetScore();
        SceneManager.LoadScene(11);
    }
    public void LoadLevel_6()
    {
        ScoreManager.ResetScore();
        SceneManager.LoadScene(13);
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadGallery()
    {
        SceneManager.LoadScene(16);
    }

    public void QuitGame() {
        Debug.Log("Quitting Game....");
        Application.Quit();
    }
}
