using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantWPF.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        public ICommand LogoutCommand { get; }

        public BaseViewModel()
        {
            LogoutCommand = new RelayCommand(ExecuteLogout);
        }

        private void ExecuteLogout(object obj)
        {
            UserSession.Clear();

            var login = new LoginWindow();
            login.Show();

            foreach (Window w in Application.Current.Windows)
            {
                if (w != login)
                    w.Close();
            }
        }
    }
}
