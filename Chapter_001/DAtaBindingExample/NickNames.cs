
using System.Collections.ObjectModel;

namespace DAtaBindingExample
{

    // INotifyCollectionChanged: Standard way of notifying consumers of collection when they change.
    // ObservableCollection: implementation of INotifyCollectionChanged provided by WPF.
    public class NickNames : ObservableCollection<NickName>
    {
    }
}
