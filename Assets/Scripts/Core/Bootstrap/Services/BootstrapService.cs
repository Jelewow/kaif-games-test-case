using System.Collections;
using Bootstrap;
using KaifGames;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class BootstrapService : IInitializable
{
    [Inject] private ICoroutineRunner _coroutineRunner;
    [Inject] private LoadingScreen _loadingScreen;

    public void Initialize()
    {
        SetSystemSettings();

        StartGame();
    }

    private void SetSystemSettings()
    {
        Application.targetFrameRate = 60;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    private void StartGame()
    {
        _coroutineRunner.StartCoroutine(LoadGame());
    }

    private IEnumerator LoadGame()
    {
        _loadingScreen.Show();

        var sceneLoader = new SceneLoader.SceneLoader(_coroutineRunner);
        sceneLoader.Load("Game");

        _loadingScreen.Hide();

        yield return null;
    }
}