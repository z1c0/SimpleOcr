using Newport;
using System;
using System.Linq;
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
      Rows = Cols = 10;
      Cells = Enumerable.Range(0, Rows * Cols).Select(_ => new CellViewModel()).ToList();
    }

    public int Cols { get; set; }

    public int Rows { get; set; }

    public IEnumerable<CellViewModel> Cells { get; private set; }
  }
}
