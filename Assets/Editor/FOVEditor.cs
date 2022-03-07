using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CharacterFOV))]
public class FOVEditor : Editor
{
  void OnSceneGUI()
    {
        CharacterFOV fov = (CharacterFOV)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fov.transform.position, Vector3.up, Vector3.forward, 360, fov.viewRadius);
    }
}
