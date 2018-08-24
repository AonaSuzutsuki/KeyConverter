﻿using CommonStyleLib.ViewModels;
using KeyConverterGUI.Models;
using Prism.Commands;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KeyConverterGUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Window window, MainWindowModel model) : base(window, model)
        {
            this.model = model;

            #region Initialize Properties
            ButtonText = model.ToReactivePropertyAsSynchronized(m => m.ButtonText);
            #endregion

            #region Initialize Events
            EnabledBtClicked = new DelegateCommand(EnabledBt_Clicked);
            #endregion
        }

        #region Fields
        private readonly MainWindowModel model;
        #endregion

        #region Properties
        public ReactiveProperty<string> ButtonText { get; set; }
        #endregion

        #region Event Properties
        public ICommand EnabledBtClicked { get; set; }
        #endregion

        #region Event Methods
        protected override void MainWindow_Closing()
        {
            model.Dispose();
        }

        public void EnabledBt_Clicked()
        {
            model.EnabledOrDisabled();
        }
        #endregion
    }
}