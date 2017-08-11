using Core.Models.Model;
using Core.ViewModels.ViewModel;
using System.Collections.Generic;

namespace Core.ViewModels.ViewModel
{
    public class SignUpViewModel : BaseViewModel
    {
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public SignUpViewModel()
        {

        }

        #region Properties

        private List<Gender> genderList;
        public List<Gender> GenderList
        {
            get { return genderList; }
            set { genderList = value; }
        }


        private Gender selectedGender;
        public Gender SelectedGender
        {
            get { return selectedGender; }
            set
            {
                selectedGender = value;
            }
        }

        #endregion
    }
}
