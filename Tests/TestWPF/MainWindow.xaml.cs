﻿using System;
using System.Windows;
using System.Net;
using System.Net.Mail;
using System.Security;


namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            var userName = tbUserName.Text;
            SecureString userPassword = pbPassword.SecurePassword;
            EmailSendServiceClass emailSend = new EmailSendServiceClass();
            emailSend.MessageSubject = tbMailTopic.Text;
            emailSend.MessageSubject = tbMailText.Text;
            emailSend.To = tbUserName.Text;

            emailSend.SendMail(userName, userPassword);
        }

        private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
