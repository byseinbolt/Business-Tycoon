
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
   [UsedImplicitly]
   public void StartGame()
   {
      SceneManager.LoadSceneAsync("game_scene");
   }
}
