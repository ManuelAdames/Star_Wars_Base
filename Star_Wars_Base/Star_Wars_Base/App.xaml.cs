﻿using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Star_Wars_Base
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null): base(initializer) { }
        protected override void OnInitialized()
        {
            InitializeComponent();
        }


        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }




    }
}
