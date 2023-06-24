using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class scrSandwichManager : MonoBehaviour
{
    [SerializeField] List<string> _ingredientes;
    [SerializeField] scrSandwich[] _sandwichSO;
    [SerializeField] List<string> _ingredientesPedido;
    [SerializeField] TextMeshProUGUI _txtNameSandwich;
    [SerializeField] TextMeshProUGUI _txtInfoIngredientes;
    [SerializeField] TextMeshProUGUI _txtPoints;
    [SerializeField] TextMeshProUGUI _txtIngredientes;
    [SerializeField] TextMeshProUGUI _txtFeedback;
    [SerializeField] TextMeshProUGUI _txtMinutes;
    [SerializeField] TextMeshProUGUI _txtSeconds;
    [SerializeField] TextMeshProUGUI _txtPontuação;
    [SerializeField] int limitOfSeconds;
    [SerializeField] float seconds;
    [SerializeField] int minutes;
    public Image _imageSandwich;
    public int pedido;
    public bool _start = false;
    public bool _end = false;
    public int index;
    public int txtIndex;
    public int limite = 3;
    float points;
    [SerializeField] GameObject _pnlEndGame;
    [SerializeField] GameObject _Bell;
    [SerializeField] GameObject _pnlPause;
    public AudioClip _Good;
    public AudioClip _Bad;
    public AudioSource btnSFX;
    private enum gameState { onGame, Pause }
    private gameState gameUpdate;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Pedido", 0.1f);
        gameUpdate = gameState.onGame;
    }

    private void Update()
    {
        if (gameUpdate == gameState.Pause)
        {
            Time.timeScale = 0;
        }

        if (gameUpdate == gameState.onGame)
        {
            Time.timeScale = 1;

            //cronometro
            if (_start == true)
            {
                seconds += Time.deltaTime;
            }

            if (seconds >= limitOfSeconds)
            {
                minutes++;
                seconds = 0;
            }

            index = _ingredientes.Count;

            if (_start == true)
            {
                Clock();
            }

            if (minutes == 2)
            {
                Fim();
                gameUpdate = gameState.Pause;
            }
        }
    }

    public void Clock()
    {
        _txtMinutes.text = minutes.ToString("00");
        _txtSeconds.text = seconds.ToString("00");
    }

    public void btnRestart() 
    {
        btnSFX.Play();
        SceneManager.LoadScene(1);
    }

    public void Fim() 
    {
        _pnlEndGame.SetActive(true);
        _txtPontuação.text = "Score: " + points.ToString();
        _end = true;
    }

    public void Pedido() 
    {
        //com um valor randomico que vai de 1 a 10, ele pega as informações dos scriptable objects e adiciona ao painel onde vai ser feito o pedido.
        pedido = Random.Range(1, 10);
        switch (pedido)
        {
            case 1: _imageSandwich.sprite = _sandwichSO[0].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[0].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[0].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[0].ingredientes[0] + "\n-" + _sandwichSO[0].ingredientes[1] + "\n-" + _sandwichSO[0].ingredientes[2];
                break;

            case 2: _imageSandwich.sprite = _sandwichSO[1].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[1].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[1].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[1].ingredientes[0] + "\n-" + _sandwichSO[1].ingredientes[1] + "\n-" + _sandwichSO[1].ingredientes[2];
                break;

            case 3:_imageSandwich.sprite = _sandwichSO[2].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[2].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[2].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[2].ingredientes[0] + "\n-" + _sandwichSO[2].ingredientes[1] + "\n-" + _sandwichSO[2].ingredientes[2];
                break;

            case 4:_imageSandwich.sprite = _sandwichSO[3].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[3].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[3].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[3].ingredientes[0] + "\n-" + _sandwichSO[3].ingredientes[1] + "\n-" + _sandwichSO[3].ingredientes[2];
                break;

            case 5:_imageSandwich.sprite = _sandwichSO[4].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[4].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[4].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[4].ingredientes[0] + "\n-" + _sandwichSO[4].ingredientes[1] + "\n-" + _sandwichSO[4].ingredientes[2];
                break;

            case 6:_imageSandwich.sprite = _sandwichSO[5].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[5].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[5].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[5].ingredientes[0] + "\n-" + _sandwichSO[5].ingredientes[1] + "\n-" + _sandwichSO[5].ingredientes[2];
                break;

            case 7:_imageSandwich.sprite = _sandwichSO[6].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[6].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[6].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[6].ingredientes[0] + "\n-" + _sandwichSO[6].ingredientes[1] + "\n-" + _sandwichSO[6].ingredientes[2];
                break;

            case 8:_imageSandwich.sprite = _sandwichSO[7].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[7].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[7].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[7].ingredientes[0] + "\n-" + _sandwichSO[7].ingredientes[1] + "\n-" + _sandwichSO[7].ingredientes[2];
                break;

            case 9:_imageSandwich.sprite = _sandwichSO[8].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[8].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[8].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[8].ingredientes[0] + "\n-" + _sandwichSO[8].ingredientes[1] + "\n-" + _sandwichSO[8].ingredientes[2];
                break;

            case 10:_imageSandwich.sprite = _sandwichSO[9].icon;
                for (int i = 0; i < 3; i++)
                {
                    _ingredientesPedido.Add(_sandwichSO[9].ingredientes[i]);
                }

                _txtNameSandwich.text = _sandwichSO[9].name;
                _txtInfoIngredientes.text = "-" + _sandwichSO[9].ingredientes[0] + "\n-" + _sandwichSO[9].ingredientes[1] + "\n-" + _sandwichSO[9].ingredientes[2];
                break;
        }
    }

    //botões que adicionam os ingredientes
    public void btnSalada() { if (_ingredientes.Count <= limite && _end == false) { _ingredientes.Add("salada"); _txtIngredientes.text += "\n" + "- salada"; btnSFX.Play(); }  }
    public void btnHamburguer() { if (_ingredientes.Count <= limite && _end == false) { _ingredientes.Add("hamburguer"); _txtIngredientes.text += "\n" + "- hamburguer"; btnSFX.Play(); }  }
    public void btnTomate() { if (_ingredientes.Count <= limite && _end == false) { _ingredientes.Add("tomate"); _txtIngredientes.text += "\n" +"- tomate"; btnSFX.Play(); }  }
    public void btnPicles() { if (_ingredientes.Count <= limite && _end == false) { _ingredientes.Add("picles"); _txtIngredientes.text += "\n" +"- picles"; btnSFX.Play(); }  }
    public void btnQueijo() { if (_ingredientes.Count <= limite && _end == false) { _ingredientes.Add("queijo"); _txtIngredientes.text += "\n" + "- queijo"; btnSFX.Play(); }  }

    //botão para limpar a lista de ingredientes
    public void btnVoltar() 
    {
        if (_end == false) 
        {
            _ingredientes.Clear();

            _txtIngredientes.text = "";
        } 
    }

    //botão que confere se o pedido esta correto
    public void btnEntregar() 
    {
        if (_end == false)
        {
            _Bell.GetComponent<Animator>().SetTrigger("ring");
            _Bell.GetComponent<AudioSource>().Play();
            ChecarPedido();
            Invoke("Pedido", 0.5f);
        }
    }

    public void btnPause() 
    {
        gameUpdate = gameState.Pause;
        _pnlPause.SetActive(true);
    }

    public void btnPlay() 
    {
        gameUpdate = gameState.onGame;
        _pnlPause.SetActive(false);
    }

    //metodo feito para validar as inforamções do pedido aos ingredientes selecionados pelo jogador
    public void ChecarPedido() 
    {
        if (_ingredientes[0] == _ingredientesPedido[0] && _ingredientes[1] == _ingredientesPedido[1] && _ingredientes[2] == _ingredientesPedido[2])
        {
            _Bell.GetComponent<AudioSource>().clip = _Good;
            _Bell.GetComponent<AudioSource>().Play();

            _ingredientes.Clear();
            _ingredientesPedido.Clear();
            _imageSandwich.sprite = null;
            _txtInfoIngredientes.text = "";
            _txtNameSandwich.text = "";
            _txtIngredientes.text = "";

            points += 10;
            _txtPoints.text = "R$: " + points.ToString() + ",00";

            _txtFeedback.text = "Pedido entregue corretamente!";
        }
        else
        {
            _Bell.GetComponent<AudioSource>().clip = _Bad;
            _Bell.GetComponent<AudioSource>().Play();

            _ingredientes.Clear();
            _ingredientesPedido.Clear();
            _imageSandwich.sprite = null;
            _txtInfoIngredientes.text = "";
            _txtNameSandwich.text = "";
            _txtIngredientes.text = "";

            points -= 10;
            _txtPoints.text = "R$: " + points.ToString() + ",00";

            _txtFeedback.text = "Pedido errado!!!";

        }
    }
}
