using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork_Common;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string GameFileAssetname = "Zork";

    [SerializeField]
    public UnityOutputService OutputService;

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    public Text ScoreText;

    [SerializeField]
    public Text LocationText;

    [SerializeField]
    public Text MovesText;

    private Game Game { get; set; }

    private int Moves = 0; 
    

    void Awake()
    {
        TextAsset gameFileAsset = Resources.Load<TextAsset>(GameFileAssetname);
        Game = Game.Load(gameFileAsset.text, OutputService, InputService);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            if (string.IsNullOrWhiteSpace(InputService.InputField.text) == false)
            {
                Game.Output.WriteLine($"> {InputService.InputField.text}");
                InputService.ProcessInput();
                ScoreText.text = $"Score: {Game.Player.Score}";
                LocationText.text = Game.Player.Location.Name;
                MovesText.text = $"Moves: {(Game.Player.Moves)}"; 
            }
            InputService.InputField.text = string.Empty;
            InputService.InputField.Select();
            InputService.InputField.ActivateInputField();
        }
        if (!Game.IsRunning)
        {
            Application.Quit(); 
        }
    }

}
