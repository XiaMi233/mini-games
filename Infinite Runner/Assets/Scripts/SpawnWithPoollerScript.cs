using UnityEngine;
using System.Collections;

public class SpawnWithPoollerScript : MonoBehaviour {

  //public GameObject[] obj;
  public float spawnMin = 1f;
  public float spawnMax = 2f;


  // Use this for initialization
  void Start() {
    Spawn();
  }

  void Spawn() {
    GameObject obj = ObejctPoolerScript.current.getPoolledObj();
    if (obj) {
      obj.transform.position = transform.position;
      obj.SetActive(true);
    }
    Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    //Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
    //Invoke("Spawn", Random.Range(spawnMin, spawnMax));
  }
}
