using GalaSoft.MvvmLight;
using System;

namespace Core.Models.Model
{
    public class Account : ViewModelBase
    {
        public int Id { get; set; }
        public bool IsFacebook { get; set; }
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged(() => password);
            }
        }

        private string image;
        public string Image
        {
            get { return image; }
            set { image = value; RaisePropertyChanged(() => Image); }
        }

        private int rank;
        public int Rank
        {
            get { return rank; }
            set { rank = value; RaisePropertyChanged(() => Rank); }
        }

        private DateTime birthdate;
        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; RaisePropertyChanged(() => birthdate); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; RaisePropertyChanged(() => email); }
        }

        private string firstname;
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; RaisePropertyChanged(() => firstname); }
        }

        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; RaisePropertyChanged(() => lastname); }
        }

        private int mobile;
        public int Mobile
        {
            get { return mobile; }
            set { mobile = value; RaisePropertyChanged(() => mobile); }
        }

        private string confirmPassword;
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; RaisePropertyChanged(() => confirmPassword); }
        }

        public override string ToString()
        {
            return UserName;
        }
    }
}
