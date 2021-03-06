//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18408
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;

public class Obstaculizador : MonoBehaviour
{
	[SerializeField]
	private Transform _obstaculo;
	[SerializeField]
	private float _cooldown = 1;
	private float _timer;

	private Camera _cam;
	private float _tiempo_inicial;
	void Start()
	{
		_cam = Camera.main;
		_timer = _cooldown;
		_tiempo_inicial = Time.time;
	}

	void Update()
	{
		if (_timer <= 0)
		{
			foreach (Touch t in Input.touches)
			{
				if (t.phase == TouchPhase.Began)
				{
					Vector3 tPos = _cam.ScreenToWorldPoint(t.position);
					Vector3 rec = _cam.ViewportToWorldPoint(new Vector3(0,1));

					Transform obs = (Transform)Instantiate(_obstaculo,new Vector3(tPos.x,rec.y,0),Quaternion.Euler(Vector3.zero));
					obs.GetComponent<Obstaculo>()._velocidad += (Time.time - _tiempo_inicial) *0.1f;
					_timer = _cooldown;
					break;
				}
			}
		}
		else
			_timer -= Time.deltaTime;
	}
}

