using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public void LoadGame()
    {
        SCManager.Instance.LoadScene( "GameScene" );
    }
}
