using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Button : MonoBehaviour
{
    public float time = 2;
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
        Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Basketball.prefab", typeof(GameObject));
        GameObject clone = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
        Vector3 pos = Vector3.zero;
        pos.Set(-1.34f, -0.23f, 4.89f);
        clone.transform.position = pos;
            time = 2;
        }

    }


}
