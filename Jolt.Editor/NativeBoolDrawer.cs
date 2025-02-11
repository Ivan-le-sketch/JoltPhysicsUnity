using UnityEditor;
using UnityEngine;

namespace Jolt
{
    [CustomPropertyDrawer(typeof(NativeBool))]
    public class NativeBoolCustomDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            SerializedProperty valueProp = property.FindPropertyRelative("Value");

            // Ensure the byte is treated as a boolean for toggle usage
            bool toggle = valueProp.intValue != 0;
            toggle = EditorGUI.Toggle(position, label, toggle);

            // Set the byte value based on the toggle's state
            valueProp.intValue = toggle ? 1 : 0;

            EditorGUI.EndProperty();
        }
    }
}
