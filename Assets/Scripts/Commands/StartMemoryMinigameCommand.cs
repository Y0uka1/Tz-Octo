using DTT.MinigameMemory;
using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Commands
{
    [CommandAlias("StartMemory")]
    public class StartMemoryMinigameCommand:Command
    {
        public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
        {
            await SceneManager.LoadSceneAsync("MiniGame");
            await GameObject.FindObjectOfType<MemoryGameManager>().OnGameEnd();
            await UniTask.CompletedTask;
        }
        
    }
}