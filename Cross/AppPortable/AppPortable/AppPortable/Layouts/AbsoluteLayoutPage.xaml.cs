﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPortable.Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }
    }
}