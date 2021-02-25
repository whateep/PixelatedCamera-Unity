using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PixelatedCamera))]
public class PixelatedCameraEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PixelatedCamera pc = (PixelatedCamera)target;

        // When the inspector is drawn (or any values are changed) re-initialize the render texture
        if (DrawDefaultInspector() || pc.CheckScreenResize()) pc.Init();
    }
}
