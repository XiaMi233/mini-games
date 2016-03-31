using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObejctPoolerScript : MonoBehaviour {

  public static ObejctPoolerScript current;

  public GameObject gameObj;

  public int pooledAmout = 20;

  public bool willGrow = true;

  List<GameObject> pooledList = new List<GameObject>();

  void Awake () {
    current = this;
  }

	void Start () {
    for (int i = 0; i < pooledAmout; ++i) {
      GameObject obj = Instantiate(gameObj);
      obj.SetActive(false);

      pooledList.Add(obj);
    }	
	}

  public GameObject getPoolledObj() {
    for (int i = 0; i < pooledList.Count; ++i) {
      if (!pooledList[i].activeInHierarchy) {
        return pooledList[i];
      }
    }

    if (willGrow) {
      GameObject obj = Instantiate(gameObj);
      pooledList.Add(obj);
      return obj;
    }

    return null;
  }
}
