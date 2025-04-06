using GRPU.Extensions;
using GRPU.Utils;
using GRPU.Utils.Spawners;
using UnityEngine;

public class GameManager 
    : MonoShared<GameManager>
{
    static System.Random _rng = new System.Random();
    public Timer timer;

    void Start()
    {
        AudioManager.Instance.PlayMusic( "MainTheme" );

        timer = this.GetOrAddComponent<Timer>();
        GetComponent<MultiSpawner>()
            .afterSpawn
            .AddListener( ( go ) => {
                AudioManager.Instance.PlaySFX( "Rock", AudioManager.CHAN_BUBBLES );
                go.transform.eulerAngles = new() {
                    z = _rng.NextFloat(0, 360),
                };
            } );
    }

    void Update()
    {
        
    }

    public void GameOver()
    {
        AudioManager.Instance.StopMusic();
        AudioManager.Instance.PlaySFX( "Death", AudioManager.CHAN_DEATH );
        GRPU_Prefs.SetFloat( "_score", timer.Secs );
        SCManager.Instance.LoadScene( "GameOver" );
    }
}
