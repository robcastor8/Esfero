using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

	private Text _puntuacion;
	private Arabes _controlador;

	// Use this for initialization
	void Start () {
		_controlador = FindObjectOfType<Arabes>();
		_puntuacion = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		_puntuacion.text = _controlador.Puntuacion.ToString("0.00");
	}
}
