using System;
using System.Collections;
using Bootstrap;
using UnityEngine.SceneManagement;

namespace SceneLoader
{
    public class SceneLoader
    {
        private readonly ICoroutineRunner _coroutineRunner;

        public SceneLoader(ICoroutineRunner coroutineRunner)
        {
            _coroutineRunner = coroutineRunner;
        }

        public void Load(string name, Action onLoaded = null)
        {
            _coroutineRunner.StartCoroutine(LoadScene(name, onLoaded));
        }

        private IEnumerator LoadScene(string name, Action onLoaded = null)
        {
            var asyncOperation = SceneManager.LoadSceneAsync(name);

            while (!asyncOperation.isDone)
            {
                yield return null;
            }
            
            onLoaded?.Invoke();
        }
    }
}