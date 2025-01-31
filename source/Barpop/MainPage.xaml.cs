﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Barpop
{
    public partial class MainPage : ContentPage
    {
        List<LoginInfo> member;
        public MainPage()
        {
            member = new List<LoginInfo>();
            InitializeComponent();
        }
        public void OnSave(object o, EventArgs e)
        {
            member.Add(new LoginInfo(
                                    FirstName.Text,
                                    MiddleName.Text,
                                    LastName.Text,
                                    SetDateTime(
                                        Date.Date,
                                        Time.Time.Hours,
                                        Time.Time.Minutes,
                                        Time.Time.Seconds
                                    )
                                )
                        );

        }

        public async void OnView(object o, EventArgs e)
        {
            await DisplayAlert("Members", member[0].FirstName + "," + member[0].MiddleName + "," + member[0].LastName + "," + member[0].DateTime, "Cancel");
        }

        private DateTime SetDateTime(DateTime date, int hour, int minute, int seconds)
        {
            return new DateTime(date.Year, date.Month, date.Day, hour, minute, seconds);
        }
    }
}