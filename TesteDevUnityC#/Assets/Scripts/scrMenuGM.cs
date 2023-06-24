using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrMenuGM : MonoBehaviour
{
    [SerializeField] GameObject[] _Paineis;
    [SerializeField] GameObject _btnIniciar;
    public int count = 0;
    public int newCount;
    private enum State { state1, state2, state3 }
    private State _state;
    // Start is called before the first frame update
    void Start()
    {
        _state = State.state1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _state == State.state2)
        {
            if (count == 3)
            {
                _state = State.state3;
            }

            _Paineis[newCount].SetActive(false);

            if (_state == State.state3)
            {
                SceneManager.LoadScene(1);
            }

            _Paineis[count].SetActive(true);
            count++;
            newCount = count - 1;
        }    
    }

    public void btnIniciar() 
    {
        _btnIniciar.SetActive(false);
        _Paineis[0].SetActive(true);
        count++;
        _state = State.state2;
    }
}
