using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyplank : MonoBehaviour {

	public int Mollah = 0;
	public Text Moneytext;
	public GameObject Plank1;
	public GameObject Plank2;
	public GameObject Plank3;
	public GameObject Plank4;
	public GameObject Plank5;
	public GameObject Plank6;
	public GameObject Plank7;
	public GameObject Plank8;
	public GameObject Plank9;
	public int planknum = 0;
	public GameObject Spawner1;
	public GameObject Spawner2;
	public GameObject Spawner3;
	public GameObject Spawner4;
	public GameObject Spawner5;
	public GameObject Spawner6;
	public GameObject Spawner7;
	public GameObject Spawner8;


	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	




		if (Input.GetKeyDown(KeyCode.H)) {
			if (Mollah >= 200) {
				if (planknum >= 0) 
					Plank1.gameObject.SetActive (true);
					Mollah = 0;
					planknum += 1;
					Spawner1.gameObject.SetActive (true);
				    Moneytext.text = Mollah.ToString ();
				}
				else if (Mollah >= 400) {
					if (planknum <= 1) {
						Plank2.gameObject.SetActive (true);
						Mollah = 0;
						planknum += 1;
						Spawner2.gameObject.SetActive (true);
					    Moneytext.text = Mollah.ToString ();
				}
				else if (Mollah >= 600) {
					if (planknum >= 2) {
						Plank3.gameObject.SetActive (true);
						Mollah = 0;
						planknum += 1;
						Spawner3.gameObject.SetActive (true);
						Moneytext.text = Mollah.ToString ();
		}
						else if (Mollah >= 800) {
							if (planknum >= 3) {
								Plank4.gameObject.SetActive (true);
								Mollah = 0;
								planknum += 1;
								Spawner4.gameObject.SetActive (true);
							Moneytext.text = Mollah.ToString ();
	}
							else if (Mollah >= 1200) {
								if (planknum >= 4) {
									Plank5.gameObject.SetActive (true);
									Mollah = 0;
									planknum += 1;
									Spawner5.gameObject.SetActive (true);
								Moneytext.text = Mollah.ToString ();
}
								else if (Mollah >= 1400) {
									if (planknum >= 5) {
										Plank6.gameObject.SetActive (true);
										Mollah = 0;
										planknum += 1;
										Spawner6.gameObject.SetActive (true);
									Moneytext.text = Mollah.ToString ();
			}
									else if (Mollah >= 1600) {
										if (planknum >= 6) {
											Plank7.gameObject.SetActive (true);
											Mollah = 0;
											planknum += 1;
											Spawner7.gameObject.SetActive (true);
										Moneytext.text = Mollah.ToString ();
		}
										else if (Mollah >= 2000) {
											if (planknum >= 7) {
												Plank8.gameObject.SetActive (true);
												Mollah = 0;
												planknum += 1;
												Spawner8.gameObject.SetActive (true);
											Moneytext.text = Mollah.ToString ();
	}
											else if (Mollah >= 2200) {
												if (planknum >= 8) {
													Plank9.gameObject.SetActive (true);
													Mollah = 0;
												Moneytext.text = Mollah.ToString ();
}
											}
										}
									}
								}

							}
						}
					}
				}
			}
		}
	void Zombiekill (){
		Mollah += 50;
		Moneytext.text = Mollah.ToString ();
	}
}

											
