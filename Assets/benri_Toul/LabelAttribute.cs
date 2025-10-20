using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[System.AttributeUsage(System.AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class LabelAttribute : PropertyAttribute
{
    public readonly GUIContent Label;

    public LabelAttribute(string label)
    {
        Label = new GUIContent(label);
    }
}

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(LabelAttribute))]
public class LabelAttributeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var attr = attribute as LabelAttribute;
        var labelContent = attr != null && attr.Label != null ? attr.Label : GUIContent.none;
        EditorGUI.PropertyField(position, property, labelContent, true);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        // ƒ‰ƒxƒ‹‚ğ attr ‚Ì‚à‚Ì‚É‚µ‚Ä‚‚³‚ğŒvZ‚µ‚½‚¢‚È‚çã‚Æ“¯‚¶ˆ—‚Åæ‚èo‚µ‚Ä“n‚·
        return EditorGUI.GetPropertyHeight(property, true);
    }
}
#endif