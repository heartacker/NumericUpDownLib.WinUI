// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using CommunityToolkit.Mvvm.Input;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.UI.Popups;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NumericUpDownLib.WinUI.Base
{
    public abstract partial class InputBaseUpDown : Control
    {
        public InputBaseUpDown()
        {
            this.DefaultStyleKey = typeof(InputBaseUpDown);
        }

        #region fields

        /// <summary>
        /// Determines whether the textbox portion of the control is editable
        /// (requires additional check of bounds) or not.
        /// </summary>
        public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register(
            nameof(IsReadOnly),
            typeof(bool),
            typeof(InputBaseUpDown),
            new PropertyMetadata(false));

        /// <summary>
        /// Determines the allowed style of a number entered and displayed in the textbox.
        /// </summary>
        public static readonly DependencyProperty NumberStyleProperty = DependencyProperty.Register(
            nameof(NumberStyle),
            typeof(NumberStyles),
            typeof(InputBaseUpDown),
            new PropertyMetadata(NumberStyles.Any));

        /// <summary>
        /// Backing store of <see cref="EnableValidatingIndicator"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty EnableValidatingIndicatorProperty = DependencyProperty.Register(
            nameof(EnableValidatingIndicator),
            typeof(bool),
            typeof(InputBaseUpDown),
            new PropertyMetadata(false));

        /// <summary>
        /// Backing store of <see cref="EditingVisibility"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty EditingVisibilityProperty = DependencyProperty.Register(
            nameof(EditingVisibility),
            typeof(Visibility),
            typeof(InputBaseUpDown),
            new PropertyMetadata(Visibility.Collapsed));

        /// <summary>
        /// Backing store of <see cref="EditingColorBrush"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty EditingColorBrushProperty = DependencyProperty.Register(
            nameof(EditingColorBrush),
            typeof(SolidColorBrush),
            typeof(InputBaseUpDown),
            new PropertyMetadata(new SolidColorBrush(Colors.Green)));

        /// <summary>
        /// identify that the inputing data is valid or not.,
        /// </summary>
        /// <value></value>
        internal SolidColorBrush EditingColorBrush
        {
            get { return (SolidColorBrush)GetValue(EditingColorBrushProperty); }
            set { SetValue(EditingColorBrushProperty, value); }
        }

        /// <summary>
        /// identify that the editing Visibility
        /// </summary>
        /// <value></value>
        internal Visibility EditingVisibility
        {
            get { return (Visibility)GetValue(EditingVisibilityProperty); }
            set { SetValue(EditingVisibilityProperty, value); }
        }

        /// <summary>
        /// identify that the is enable the red/green tip while editing
        /// </summary>
        /// <value></value>
        public bool EnableValidatingIndicator
        {
            get { return (bool)GetValue(EnableValidatingIndicatorProperty); }
            set { SetValue(EnableValidatingIndicatorProperty, value); }
        }

        protected static RelayCommand _IncreaseCommand;
        protected static RelayCommand _DecreaseCommand;
        #endregion fields



        #region properties
        /// <summary>
        /// Expose the increase value command via <seealso cref="RoutedCommand"/> property.
        /// </summary>
        public RelayCommand IncreaseCommand => _IncreaseCommand;

        /// <summary>
        /// Expose the decrease value command via <seealso cref="RoutedCommand"/> property.
        /// </summary>
        public RelayCommand DecreaseCommand => _DecreaseCommand;

        /// <summary>
        /// Determines whether the textbox portion of the control is editable
        /// (requires additional check of bounds) or not.
        /// </summary>
        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }

        /// <summary>
        /// Gets/sets the allowed style of a number entered and displayed in the textbox.
        /// </summary>
        public NumberStyles NumberStyle
        {
            get { return (NumberStyles)GetValue(NumberStyleProperty); }
            set { SetValue(NumberStyleProperty, value); }
        }

        #endregion properties

        #region methods
        #region Commands
        /// <summary>
        /// Increase the displayed integer value
        /// </summary>
        protected virtual void OnIncrease() { }

        /// <summary>
        /// Determines whether the increase command is available or not.
        /// </summary>
        protected virtual bool CanIncreaseCommand()
        {
            return true;
        }

        /// <summary>
        /// Decrease the displayed integer value
        /// </summary>
        protected virtual void OnDecrease()
        {
        }

        /// <summary>
        /// Determines whether the decrease command is available or not.
        /// </summary>
        protected virtual bool CanDecreaseCommand()
        {
            return true;
        }

        /// <summary>
        /// Initialize up down/button commands and key gestures for up/down cursor keys
        /// </summary>
        private void InitializeCommands()
        {
            InputBaseUpDown._IncreaseCommand = new CommunityToolkit.Mvvm.Input.RelayCommand(
                OnIncrease, canExecute: CanIncreaseCommand
                );

            InputBaseUpDown._DecreaseCommand = new CommunityToolkit.Mvvm.Input.RelayCommand(
                OnDecrease, canExecute: CanDecreaseCommand
                );
        }
        #endregion
        #endregion methods
    }

}

