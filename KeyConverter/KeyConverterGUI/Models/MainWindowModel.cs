﻿using CommonStyleLib.Models;
using InterceptKeyboardLib.Input;
using System;
using System.Diagnostics;

namespace KeyConverterGUI.Models
{
    public class MainWindowModel : ModelBase, IDisposable
    {
        #region Constants
        private const string DISABLED_TEXT = "Now Disabled";
        private const string ENABLED_TEXT = "Now Enabled";
        #endregion

        #region Fields
        private string buttonText = DISABLED_TEXT;

        InterceptKeys interceptKeys;
        private bool isEnabled = false;
        #endregion

        #region Properties
        public string ButtonText
        {
            get => buttonText;
            set => SetProperty(ref buttonText, value);
        }
        #endregion

        public void EnabledOrDisabled()
        {
            if (!isEnabled)
            {
                interceptKeys = InterceptKeys.Instance;
                interceptKeys.Initialize();
                
                var processes = Process.GetProcessesByName("Client");
                if (processes.Length > 0)
                    interceptKeys.SpecificProcessId = processes[0].Id;

                isEnabled = true;
                ButtonText = ENABLED_TEXT;
            }
            else
            {
                interceptKeys.Dispose();

                isEnabled = false;
                ButtonText = DISABLED_TEXT;
            }
        }


        #region IDisposable
        public void Dispose()
        {
            interceptKeys?.Dispose();
        }
        #endregion
    }
}
