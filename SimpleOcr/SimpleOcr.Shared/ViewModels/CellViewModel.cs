using Newport;

namespace SimpleOcr.ViewModels
{
  public class CellViewModel : SimpleViewModelBase
  {
    private bool _isChecked;

    public CellViewModel()
    {
      TapCommand = new ActionCommand(_ => IsChecked = true);
    }

    public override string ToString()
    {
      return IsChecked.ToString();
    }

    public bool IsChecked
    {
      get
      {
        return _isChecked;
      }
      set
      {
        SetProperty(ref _isChecked, value);
      }
    }

    public ActionCommand TapCommand { get; private set; }
  }
}
