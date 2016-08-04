using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Sigleton<T> where T : class, new() {
    public static T instance;

    public Sigleton() {
    }

    public static T Instance() {
        if (instance == null) {
            instance = new T();
        }
        return instance;
    }
}

public class EffectManager : Sigleton<EffectManager> {
    private Dictionary<string, GameObject> _effectList = new Dictionary<string, GameObject>();

    public GameObject CreateEffect(string path, Transform parent) {
        GameObject effect = null;
        if (_effectList.TryGetValue(path, out effect)) {
            return effect;
        }
        else {
			Object go = Resources.Load (path);
			effect = GameObject.Instantiate (go) as GameObject;

            _effectList.Add(path, effect);
        }

        effect.transform.SetParent(parent);
        effect.transform.localRotation = Quaternion.identity;
        effect.transform.localPosition = Vector3.zero;
        effect.transform.localScale = Vector3.one;
        return effect;
    }

    public void RemoveEffect(string key) {
        GameObject effect = null;
        if (_effectList.TryGetValue(key, out effect)) {
            GameObject.Destroy(effect);
            _effectList.Remove(key);
        }
        effect = null;
    }
}