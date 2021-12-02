using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace UnityComments
{
    [CustomEditor(typeof(InspectorComment))]
    public class InspectorCommentEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            InspectorComment myTarget = (InspectorComment)target;
            myTarget.comment = EditorGUILayout.TextArea(myTarget.comment);
        }
    }
}
