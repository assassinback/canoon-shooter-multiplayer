using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarControl : MonoBehaviour {

		public ProgressBar Pb;
//		public ProgressBarCircle PbC;
		public ParticleSystem particlesystem;

		private void Start()
		{
			//		Pb = GameObject.FindGameObjectWithTag ("ProgressBar").GetComponent<ProgressBar>();

			Pb.BarValue = 100;
			//        PbC.BarValue = 50;
		}


		void OnTriggerEnter(Collider col)
		{
			if (col.gameObject.tag == "Bullet") {

				Pb.BarValue -= 7;


			}
			if (Pb.BarValue==0) {
				ParticleSystem fire= Instantiate (particlesystem, col.gameObject.transform.position, Quaternion.identity);
				Destroy (gameObject);

			}
		}
	}

