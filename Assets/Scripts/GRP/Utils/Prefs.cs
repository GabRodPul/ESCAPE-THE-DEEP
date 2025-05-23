using System;
using UnityEngine;

namespace GRPU.Utils
{
    public static class GRPU_Prefs
    {
        public static float GetFloat(string key, float failsafe)
            => PlayerPrefs.HasKey(key)
             ? PlayerPrefs.GetFloat(key)
             : failsafe;
        public static void SetFloat(string key, float value)
            => PlayerPrefs.SetFloat(key, value);

        public static bool GetBool32(string key, bool failsafe)
            => PlayerPrefs.HasKey(key)
             ? Convert.ToBoolean(PlayerPrefs.GetInt(key))
             : failsafe;

        public static void SetBool32(string key, bool value)
            => PlayerPrefs.SetInt(key, Convert.ToInt32(value));
    }
}
