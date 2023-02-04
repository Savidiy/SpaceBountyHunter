using UnityEditor;
using UnityEngine;

namespace BountyHunter.Editor
{
    public static class PlayerPrefsReset
    {
        [MenuItem("Tools/Reset player prefs")]
        public static void ResetPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("Player Prefs cleared");
        }

        [MenuItem("Tools/Reset editor prefs")]
        public static void ResetEditorPrefs()
        {
            EditorPrefs.DeleteAll();
            Debug.Log("Editor Prefs cleared");
        }
    }
}