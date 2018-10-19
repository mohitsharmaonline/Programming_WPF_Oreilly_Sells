
using System.ComponentModel;

namespace DAtaBindingExample
{
    public class NickName : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void Notify(string propName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(sender: this, e: new PropertyChangedEventArgs(propertyName: propName));
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                Notify(nameof(Name)); // Notify Consumers
            }
        }

        private string nick;

        public string Nick
        {
            get { return nick; }
            set
            {
                nick = value;
                Notify(nameof(Nick));   // Notify Consumers
            }
        }

        public NickName()
        {

        }

        public NickName(string name, string nick)
        {
            this.name = name;
            this.nick = nick;
        }

    }
}
