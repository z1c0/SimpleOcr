using Newport;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOcr.ViewModels
{
  [ExportedViewModel]
  public class MainViewModel : ViewModelBase
  {
    public MainViewModel()
    {
      Text = "Simple OCR";
    } 
  }
}
