using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM
{
    public class MainWindowsViewModel : NotifyPropertyChangedBase
    {
        private ObservableCollection<User> _UserList = new ObservableCollection<User>();
        public ObservableCollection<User> UserList { get { return _UserList; } set { _UserList = value; OnPropertyChanged("UserList"); } }

        private ICommand _UserInfoCommand;
        public ICommand UserInfoCommand
        {
            get
            {
                if (_UserInfoCommand == null)
                    _UserInfoCommand = new RelayCommand(p => this.UserInfo());
                return _UserInfoCommand;
            }
        }

        private void UserInfo()
        {
            UserList = new ObservableCollection<User>();

            User user = new User();
            user.Name = "홍길동";
            user.Sex = "남자";
            user.Age = "20";
            user.Address = "서울";

            User user1 = new User();
            user1.Name = "유관순";
            user1.Sex = "여자";
            user1.Age = "18";
            user1.Address = "서울";

            User user2 = new User();
            user2.Name = "백종원";
            user2.Sex = "남자";
            user2.Age = "50";
            user2.Address = "충청도";

            User user3 = new User();
            user3.Name = "트럼프";
            user3.Sex = "남자";
            user3.Age = "60";
            user3.Address = "미국";

            UserList.Add(user);
            UserList.Add(user1);
            UserList.Add(user2);
            UserList.Add(user3);
        }
    }
}
