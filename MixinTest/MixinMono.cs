using UnityEngine;
using System.Collections;
using Remotion.Mixins;
using System;
using Remotion.Reflection;
using EqualsShowCase.MixinImplementation;

public class MixinMono : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
//		var wien1 = EqualsShowCase.MixinImplementation.StreetAddress.NewObject (1010, "Wien", 
//		"Stephansplatz", "1"); 
//		 var wien2 = EqualsShowCase.MixinImplementation.StreetAddress.NewObject (1010, "Wien", 
//		"Stephansplatz", "1"); 
//		 var berlin = EqualsShowCase.MixinImplementation.StreetAddress.NewObject (11011, "Berlin", 
//		"Pariser Platz", "1"); 
//		 
//		 Console.WriteLine ("Mixin Implementation: Wien = Wien: {0}", Equals (wien1, wien2)); 
//		 Console.WriteLine ("Mixin Implementation: Wien = Berlin: {0}", Equals (wien1, berlin)); 
//		 
//		 // show that the correct constructor overload is called even if the type of the city parameter cannot 
//		 // be detected at runtime (could be string or City). Would result in an AmbiguityException otherwise 
//		 var nullCitymixedAddress3 = EqualsShowCase.MixinImplementation.StreetAddress.NewObject 
//		(1010, null, "Stephansplatz", "1"); 
//		 Console.WriteLine ("Mixin Implementation: Wien = null: {0}", Equals (wien1, null)); 
		
//		 EqualsShowCase.MixinImplementation.StreetAddress mixedAddress1 = ObjectFactory.Create<EqualsShowCase.MixinImplementation.StreetAddress> (ParamList.Create (1010, "Wien", "Stephansplatz", "1"));
//     EqualsShowCase.MixinImplementation.StreetAddress mixedAddress2 = ObjectFactory.Create<EqualsShowCase.MixinImplementation.StreetAddress> (ParamList.Create(1010, "Wien", "Stephansplatz", "1"));
//     Console.WriteLine ("Mixed Implementation StreetAddress: Both instances have the same values: {0}", Equals (mixedAddress1, mixedAddress2));
// 
//     EqualsShowCase.MixinImplementation.StreetAddress mixedAddress3 = ObjectFactory.Create<EqualsShowCase.MixinImplementation.StreetAddress> (ParamList.Create (1010, default (string), "Stephansplatz", "1"));
//     EqualsShowCase.MixinImplementation.StreetAddress mixedAddress4 = ObjectFactory.Create<EqualsShowCase.MixinImplementation.StreetAddress> (ParamList.Create (1010, new City().Name = "Wien", "Stephansplatz", "1"));
//     Console.WriteLine ("Mixed Implementation StreetAddress: Both instances have the same values: {0}", Equals (mixedAddress1, mixedAddress3));
//     Console.WriteLine ("Mixed Implementation StreetAddress: Both instances have the same values: {0}", Equals (mixedAddress1, mixedAddress4));
		
		 EqualsShowCase.MixinImplementation.StreetAddress mixedAddress1 = ObjectFactory.Create<EqualsShowCase.MixinImplementation.StreetAddress> (ParamList.Create (1010, "Wien", "Stephansplatz", "1"));
     EqualsShowCase.MixinImplementation.StreetAddress mixedAddress2 = ObjectFactory.Create<EqualsShowCase.MixinImplementation.StreetAddress> (ParamList.Empty);
     Console.WriteLine ("Mixed Implementation StreetAddress: Both instances have the same values: {0}", Equals (mixedAddress1, mixedAddress2));
	}
	

}

