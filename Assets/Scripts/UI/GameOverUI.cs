using GRPU.Utils;
using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] TMP_Text _tmp;

    void Start()
    {
        _tmp.text =
            "    YOU SURVIVED FOR:\n    " +
            Timer.SpanMinutes( GRPU_Prefs.GetFloat( "_score", 0f ) )
            .ToString();
    }

    public void MainMenu()
    {
        SCManager.Instance.LoadScene( "MainMenu" );
    }
}
