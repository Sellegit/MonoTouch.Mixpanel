using System;

using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace MonoTouch.Mixpanel {

	public delegate void MixpanelSurveyCompletion (NSArray surveys);

	[BaseType (typeof (NSObject))]
	public partial interface Mixpanel {

		[Export ("people", ArgumentSemantic.Retain)]
		MixpanelPeople People { get; }

		[Export ("distinctId", ArgumentSemantic.Copy)]
		string DistinctId { get; }

		[Export ("nameTag", ArgumentSemantic.Copy)]
		string NameTag { get; set; }

		[Export ("serverURL", ArgumentSemantic.Copy)]
		string ServerURL { get; set; }

		[Export ("flushInterval")]
		uint FlushInterval { get; set; }

		[Export ("flushOnBackground")]
		bool FlushOnBackground { get; set; }

		[Export ("showNetworkActivityIndicator")]
		bool ShowNetworkActivityIndicator { get; set; }

		[Export ("checkForSurveysOnActive")]
		bool CheckForSurveysOnActive { get; set; }

		[Export ("showSurveyOnActive")]
		bool ShowSurveyOnActive { get; set; }

		[Export ("checkForNotificationsOnActive")]
		bool CheckForNotificationsOnActive { get; set; }

		[Export ("showNotificationOnActive")]
		bool ShowNotificationOnActive { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		MixpanelDelegate Delegate { get; set; }

		[Static, Export ("sharedInstanceWithToken:")]
		Mixpanel SharedInstanceWithToken (string apiToken);

		[Static, Export ("sharedInstance")]
		Mixpanel SharedInstance { get; }

		[Export ("initWithToken:andFlushInterval:")]
		IntPtr Constructor (string apiToken, uint flushInterval);

		[Export ("identify:")]
		void Identify (string distinctId);

		[Export ("track:")]
		void Track (string eventName);

		[Export ("track:properties:")]
		void Track (string eventName, NSDictionary properties);

		[Export ("registerSuperProperties:")]
		void RegisterSuperProperties (NSDictionary properties);

		[Export ("registerSuperPropertiesOnce:")]
		void RegisterSuperPropertiesOnce (NSDictionary properties);

		[Export ("registerSuperPropertiesOnce:defaultValue:")]
		void RegisterSuperPropertiesOnce (NSDictionary properties, NSObject defaultValue);

		[Export ("unregisterSuperProperty:")]
		void UnregisterSuperProperty (string propertyName);

		[Export ("clearSuperProperties")]
		void ClearSuperProperties ();

		[Export ("currentSuperProperties")]
		NSDictionary CurrentSuperProperties { get; }

		[Export ("reset")]
		void Reset ();

		[Export ("flush")]
		void Flush ();

		[Export ("archive")]
		void Archive ();

		[Export ("showSurveyWithID:")]
		void ShowSurveyWithID (uint ID);

		[Export ("showSurvey")]
		void ShowSurvey ();

		[Export ("showNotificationWithID:")]
		void ShowNotificationWithID (uint ID);

		[Export ("showNotificationWithType:")]
		void ShowNotificationWithType (string type);

		[Export ("showNotification")]
		void ShowNotification ();

		[Export ("createAlias:forDistinctID:")]
		void CreateAlias (string alias, string distinctID);

		// LL: Added this for Tink
		[Export ("lla_checkForSurveysWithCompletion:")]
		void LLACheckForSurveys (MixpanelSurveyCompletion completion);

		[Export ("lla_showSurveyWithObject:")]
		void LLAShowSurvey (NSObject survey);

		[Export ("lla_markSurvey:shown:withAnswerCount:")]
		void LLAMarkSurvey (NSObject survey, bool shown, int count);
	}

	[BaseType (typeof (NSObject))]
	public partial interface MixpanelPeople {

		[Export ("addPushDeviceToken:")]
		void AddPushDeviceToken (NSData deviceToken);

		[Export ("set:")]
		void Set (NSDictionary properties);

		[Export ("set:to:")]
		void Set (string property, NSObject obj);

		[Export ("once")]
		NSDictionary Once { set; }

		[Export ("increment:")]
		void Increment (NSDictionary properties);

		[Export ("increment:by:")]
		void Increment (string property, NSNumber amount);

		[Export ("append:")]
		void Append (NSDictionary properties);

		[Export ("union:")]
		void Union (NSDictionary properties);

		[Export ("trackCharge:")]
		void TrackCharge (NSNumber amount);

		[Export ("trackCharge:withProperties:")]
		void TrackCharge (NSNumber amount, NSDictionary properties);

		[Export ("clearCharges")]
		void ClearCharges ();

		[Export ("deleteUser")]
		void DeleteUser ();
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface MixpanelDelegate {

		[Export ("mixpanelWillFlush:")]
		bool MixpanelWillFlush (Mixpanel mixpanel);
	}
}
