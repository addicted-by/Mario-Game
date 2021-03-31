using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public enum MenuTypes : byte
{
    MainMain = 0,
    OptionsMenu = 1,
    PauseMenu = 2,
    GameOverMenu = 3,
}

public class GameManagerScript : MonoBehaviour
{
    // public AudioClip ClickSound;
    public Text counter;
    public MenuTypes ActiveMenu { get; set; }

    public bool IsMenuActive { get; set; }

    //private AudioSource m_SoundSource;

    private Settings m_Settings = new Settings();

    private readonly GUI.WindowFunction[] MenuFunctions = null;

    private readonly string[] MenuNames = new string[] 
    { 
        "Main Menu",        // 0
        "Options Menu",     // 1
        "Pause Menu",       // 2
        "Game Over Menu",   // 3
    };

    public GameManagerScript()
    {
        MenuFunctions = new GUI.WindowFunction[]
        {
            MainMenu,       // 0
            OptionsMenu,    // 1
            PauseMenu,      // 2
            GameOverMenu,   // 3
        };
    }

    void Awake()
    {
        ActiveMenu = MenuTypes.MainMain;
        IsMenuActive = true;

        Application.runInBackground = true;

        DontDestroyOnLoad(gameObject);

      //  m_SoundSource = Camera.main.transform.Find("Sound").GetComponent<AudioSource>();

        //m_Settings.Load(
          //  Camera.main.transform.Find("Music").GetComponent<AudioSource>(),
            //m_SoundSource);
    }

    // Use this for initialization
    bool flag = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.text == 5.ToString())
        {
            SceneManager.LoadScene(1);
            flag = false;
        }
    }

    void OnGUI()
    {
        const int Width = 400;
        const int Height = 300;

        if (IsMenuActive)
        {
            Rect windowRect = new Rect(
                (Screen.width - Width) / 2,
                (Screen.height - Height) / 2,
                Width, Height);
            GUILayout.Window(0, windowRect, MenuFunctions[(byte)ActiveMenu], MenuNames[(byte)ActiveMenu]);
        }
    }

    private void MainMenu(int id)
    {
        if (GUILayout.Button("Start Game"))
        {
        //    m_SoundSource.PlayOneShot(ClickSound);
            IsMenuActive = false;
        }

        if (GUILayout.Button("Options"))
        {
          //  m_SoundSource.PlayOneShot(ClickSound);
            //m_SourceMenu = MenuType.MainMenu;
            ActiveMenu = MenuTypes.OptionsMenu;
        }

        // Doesn't work in webplayer or editor
        /*if (!Application.isWebPlayer && !Application.isEditor)
        {
            if (GUILayout.Button("Exit"))
            {
                m_SoundSource.PlayOneShot(ClickSound);
                Application.Quit();
            }
        }*/
    }

    private void OptionsMenu(int id)
    {
        
        if (GUILayout.Button("Reset High Score"))
        {
            //m_SoundSource.PlayOneShot(ClickSound);
            m_Settings.HighScore = 0;
        }

        if (GUILayout.Button("Back"))
        {
            //m_SoundSource.PlayOneShot(ClickSound);
            m_Settings.Save();
            ActiveMenu = MenuTypes.MainMain; //m_SourceMenu;
        }
    }

    private void PauseMenu(int id)
    {
    }

    private void GameOverMenu(int id)
    {
    }
}
