using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

  public Camera cam;

  public GameObject bowlingBall;

  public Text timeText;

  public GameObject gameOver;

  public GameObject restart;

  public float leftTime = 10f;

  float maxWidth;

  void Start() {
    if (cam == null) {
      cam = Camera.main;
    }
    Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
    Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);

    maxWidth = targetWidth.x - bowlingBall.GetComponent<Renderer>().bounds.extents.x;

    StartCoroutine(SpawnBall());

    UpdateTime();
  }

  void FixedUpdate() {
    if (leftTime < 0) {
      leftTime = 0;
    }
    leftTime -= Time.deltaTime;
    UpdateTime();
  }

  void UpdateTime() {
    timeText.text = "Left Time:\n" + Mathf.RoundToInt(leftTime);
  }

  IEnumerator SpawnBall() {
    yield return new WaitForSeconds(2f);

    while(leftTime > 0) {
      Vector3 spawnPosition = new Vector3(
        Random.Range(-maxWidth, maxWidth),
        GetComponent<Transform>().position.y,
        0
        );

      Quaternion spanRotation = Quaternion.identity;

      Instantiate(bowlingBall, spawnPosition, spanRotation);
      yield return new WaitForSeconds(Random.Range(1f, 2f));
    }

    yield return new WaitForSeconds(2f);
    gameOver.SetActive(true);
    restart.SetActive(true);
  }
}
