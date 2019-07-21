﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vactrak.Class
{
    public class VTConfig
    {
        public string steamPath        = "C:/Program Files (x86)/Steam", // Path to steam directory
                      defaultProfile   = "default.json";                   // Default profile to be loaded

        public uint   cooldownRefresh  = 500;                              // Cooldown refresh rate measured in milliseconds

        public bool   forceStatus      = false;                            // Forces status check on accounts with Bans
    }
}

namespace vactrak.Utils
{
    public static class VTConfig
    {
        public static bool SaveConfig(ref Class.VTConfig _configClass, string _configPath)
        {
            try
            {
                using (StreamWriter _sw = new StreamWriter(_configPath, false, System.Text.Encoding.UTF8))
                {
                    _sw.WriteLine(JsonConvert.SerializeObject(_configClass));
                    _sw.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex, "Failed to save Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static Class.VTConfig LoadConfig(string _configPath)
        {
            return JsonConvert.DeserializeObject<Class.VTConfig>((new StreamReader(_configPath, System.Text.Encoding.UTF8)).ReadToEnd().ToString());
        }

    }
}
