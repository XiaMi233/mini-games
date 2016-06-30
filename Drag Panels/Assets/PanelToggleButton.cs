using UnityEngine;
using System.Collections;

public class PanelToggleButton: MonoBehaviour {

    public void TogglePanel(GameObject panel) {
        panel.SetActive(!panel.activeSelf);
    }
}
