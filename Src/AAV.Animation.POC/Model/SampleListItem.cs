﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AAV.Animation.POC.Model
{
  public class SampleListItem : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    double _ID = 0; public double ID
    {
      get => _ID;

      set
      {
        if (_ID != value)
        {
          _ID = value;
          OnPropertyChanged("ID");
        }
      }
    }
    string _Name = string.Empty; public string Name
    {
      get => _Name;

      set
      {
        if (_Name != value)
        {
          _Name = value;
          OnPropertyChanged("Name");
        }
      }
    }
    bool _Done = false; public bool IsStatusOutstandingAndNoUser
    {
      get => _Done;

      set
      {
        if (_Done != value)
        {
          _Done = value;
          OnPropertyChanged("IsStatusOutstandingAndNoUser");
        }
      }
    }
    ImageSource _Look = null; public ImageSource Look
    {
      get => _Look;

      set
      {
        if (_Look != value)
        {
          _Look = value;
          OnPropertyChanged("Look");
        }
      }
    }
  }
}