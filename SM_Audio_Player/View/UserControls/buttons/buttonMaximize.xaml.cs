﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace SM_Audio_Player.View.UserControls.buttons;

public partial class buttonMaximize : UserControl, INotifyPropertyChanged
{
    public buttonMaximize()
    {
        DataContext = this;
        MaximizeIcon = "M.3 89.5C.1 91.6 0 93.8 0 96V224 416c0 35.3 28.7 64 64 64l384 0c35.3 0 64-28.7 64-64V224 96c0-35.3-28.7-64-64-64H64c-2.2 0-4.4 .1-6.5 .3c-9.2 .9-17.8 3.8-25.5 8.2C21.8 46.5 13.4 55.1 7.7 65.5c-3.9 7.3-6.5 15.4-7.4 24zM48 224H464l0 192c0 8.8-7.2 16-16 16L64 432c-8.8 0-16-7.2-16-16l0-192z";
        InitializeComponent();
    }

    private string maximizeIcon;

    public event PropertyChangedEventHandler? PropertyChanged;

    public string MaximizeIcon
    {
        get { return maximizeIcon; }
        set 
        { 
            maximizeIcon = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MaximizeIcon"));
        }
    }


    /* Maxymalizacja okno playera*/
    private void btnMaximize_Click(object sender, RoutedEventArgs e)
    {
        if (Application.Current.MainWindow.WindowState == WindowState.Normal)
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
            MaximizeIcon = "M432 48H208c-17.7 0-32 14.3-32 32V96H128V80c0-44.2 35.8-80 80-80H432c44.2 0 80 35.8 80 80V304c0 44.2-35.8 80-80 80H416V336h16c17.7 0 32-14.3 32-32V80c0-17.7-14.3-32-32-32zM48 448c0 8.8 7.2 16 16 16H320c8.8 0 16-7.2 16-16V256H48V448zM64 128H320c35.3 0 64 28.7 64 64V448c0 35.3-28.7 64-64 64H64c-35.3 0-64-28.7-64-64V192c0-35.3 28.7-64 64-64z";
        }
        else if(Application.Current.MainWindow.WindowState == WindowState.Maximized)
        {
            Application.Current.MainWindow.WindowState = WindowState.Normal;
            MaximizeIcon = "M.3 89.5C.1 91.6 0 93.8 0 96V224 416c0 35.3 28.7 64 64 64l384 0c35.3 0 64-28.7 64-64V224 96c0-35.3-28.7-64-64-64H64c-2.2 0-4.4 .1-6.5 .3c-9.2 .9-17.8 3.8-25.5 8.2C21.8 46.5 13.4 55.1 7.7 65.5c-3.9 7.3-6.5 15.4-7.4 24zM48 224H464l0 192c0 8.8-7.2 16-16 16L64 432c-8.8 0-16-7.2-16-16l0-192z";
        }
    }
}