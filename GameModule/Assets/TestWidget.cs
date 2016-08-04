using System.Collections;
using UnityEngine;

public class TestWidget : MonoBehaviour {

    // Use this for initialization
    private void Start() {
		string path = "Effect/Battle/eff_buff/Perfab/eff_chuanjia";
		var parent = GameObject.Find("Canvas/widget").transform;
		EffectManager.Instance().CreateEffect(path, parent);
    }

    // Update is called once per frame
    private void Update() {
    }
}