using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Game : MonoBehaviour {

  public void GameRestart() {
    //Application.LoadLevel(Application.loadedLevel);
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
