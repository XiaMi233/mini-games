using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLevelAsync : MonoBehaviour {

    public GameObject loading;
    public Slider loadingBar;

    private AsyncOperation async;

    public void ClickAsync(string level) {
        loading.SetActive(true);
        StartCoroutine(LoadLevelWithBar(level));
    }

    IEnumerator LoadLevelWithBar(string level) {
        async = SceneManager.LoadSceneAsync(level);

        while (!async.isDone) {
            loadingBar.value = async.progress;
            yield return null;
        }
    }
}
