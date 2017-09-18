using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

		public Luigi2DPlayer Luigi;
		
	void OnTriggerEnter(Collider other) {

				Luigi.Grounded = true;
			
		}
		
	void OnTriggerStay(Collider other) {
			
				Luigi.Grounded = true;
			
		}
		
		void OnTriggerExit(Collider other) {
			
				Luigi.Grounded=false;
			
		}
	}

