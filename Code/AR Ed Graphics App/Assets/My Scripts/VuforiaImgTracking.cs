/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;

namespace Vuforia
{
	/// <summary>
	/// A custom handler that implements the ITrackableEventHandler interface.
	/// </summary>
	public class VuforiaImgTracking : MonoBehaviour,
	ITrackableEventHandler
	{
		#region PRIVATE_MEMBER_VARIABLES

		private TrackableBehaviour mTrackableBehaviour;


		#endregion // PRIVATE_MEMBER_VARIABLES

		public static VuforiaImgTracking  Vimg;
		public string img;
		public GameObject IsometricButton;
		//public Vuforia.VuforiaImgTracking Vimg;
		public GameObject Q;

		#region UNTIY_MONOBEHAVIOUR_METHODS

		void Start()
		{
			mTrackableBehaviour = GetComponent<TrackableBehaviour>();
			if (mTrackableBehaviour)
			{
				mTrackableBehaviour.RegisterTrackableEventHandler(this);
			}
		}

		#endregion // UNTIY_MONOBEHAVIOUR_METHODS



		#region PUBLIC_METHODS

		/// <summary>
		/// Implementation of the ITrackableEventHandler function called when the
		/// tracking state changes.
		/// </summary>
		public void OnTrackableStateChanged(
			TrackableBehaviour.Status previousStatus,
			TrackableBehaviour.Status newStatus)
		{
			if (newStatus == TrackableBehaviour.Status.DETECTED ||
				newStatus == TrackableBehaviour.Status.TRACKED ||
				newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
			{
				OnTrackingFound();
			}
			else
			{
				OnTrackingLost();
			}
		}

		#endregion // PUBLIC_METHODS



		#region PRIVATE_METHODS


		private void OnTrackingFound()
		{
			Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
			Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);
			img = mTrackableBehaviour.TrackableName;

			if (img == "q21" || img == "q22" || img == "q23" || img == "q24")
				IsometricButton.SetActive (true);

			if (img == "q25" || img == "q26" || img == "q27" || img == "q28")
				IsometricButton.SetActive (true);
			


			// Enable rendering:
			foreach (Renderer component in rendererComponents)
			{
				component.enabled = true;
			}

			// Enable colliders:
			foreach (Collider component in colliderComponents)
			{
				component.enabled = true;
			}

			Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
		}


		private void OnTrackingLost()
		{
			Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
			Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);
			IsometricButton.SetActive (false);
			img = "q";
			// Disable rendering:
			foreach (Renderer component in rendererComponents)
			{
				component.enabled = false;
			}

			// Disable colliders:
			foreach (Collider component in colliderComponents)
			{
				component.enabled = false;
			}

			Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
		}

		#endregion // PRIVATE_METHODS
		public string RecoganisedImg()
		{
			//img = mTrackableBehaviour.TrackableName;
			Debug.Log (img);
			return img;
		}

		public void ActivateFigure ()
		{

			//if(Vuforia.VuforiaImgTracking.Vimg.RecoganisedImg() != null)
			//Img = VImg.

			if (img == "q21")
				Q.SetActive (true);

			if (img == "q22")
				Q.SetActive (true);

			if (img == "q23")
				Q.SetActive (true);

			if (img == "q24")
				Q.SetActive (true);

			if (img == "q25")
				Q.SetActive (true);

			if (img == "q26")
				Q.SetActive (true);

			if (img == "q27")
				Q.SetActive (true);

			if (img == "q28")
				Q.SetActive (true);
			
			img = "q";
		}

		public void DectivateFigure ()
		{

			if(Q.activeSelf)
				Q.SetActive (false);
			
		}
	
	}
}

