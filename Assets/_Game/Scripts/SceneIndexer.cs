using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneIndexer : MonoBehaviour
{
    //Scenes with indexes from unity build window
    public enum SceneType
    {
        MainMenu = 0,
        AuthorsMenu = 2,
        OptionsMenu = 3,
        TutorialScene = 1,
        LocationOneScene = 5,
        DialogueScene = 4,
    }

    public static SceneIndexer Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else Destroy(this);

        DontDestroyOnLoad(this);
    }

    public static string GetSceneNameByType(SceneType type)
    {
        switch(type)
        {
            case SceneType.MainMenu:
                return _mainMenuSceneName;
            case SceneType.AuthorsMenu:
                return _authorsMenuSceneName;
            case SceneType.OptionsMenu: 
                return _optionsMenuSceneName;
            case SceneType.TutorialScene:
                return _tutorialSceneName;
            case SceneType.LocationOneScene:
                return _locationOneSceneName;
            case SceneType.DialogueScene:
                return _dialogueSceneName;
            default:
                return "Invalid scene";
        }
    }

    //Location names
    private static string _tutorialSceneName = "Tutorial location";
    private static string _locationOneSceneName = "Location one";
    private static string _mainMenuSceneName = "Main menu";
    private static string _authorsMenuSceneName = "Authors";
    private static string _optionsMenuSceneName = "Options menu";
    private static string _dialogueSceneName = "Dialogue scene";

}
