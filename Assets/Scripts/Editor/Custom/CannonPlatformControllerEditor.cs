using UnityEngine;
using UnityEditor;

namespace CannonPlatform.Editor
{
    [CustomEditor(typeof(CannonPlatformController))]
    public class CannonPlatformControllerEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector(); // Draws the default inspector

            var script = (CannonPlatformController)target;

            if (GUILayout.Button("Move Up (1f)"))
            {
                script.MoveUp(1.0f); // Calls MoveUp on the target object
            }

            if (GUILayout.Button("Move Down (1f)"))
            {
                script.MoveDown(1.0f); // Calls MoveDown on the target object
            }
        }
    }
}