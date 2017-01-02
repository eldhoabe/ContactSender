using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System.ComponentModel;

namespace ContactChooserTest
{
    public partial class MainPage : PhoneApplicationPage, INotifyPropertyChanged
    {
        // Constructor


        #region INotify

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event 
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _phonenumber;

        public string PhoneNumber
        {
            get { return _phonenumber; }
            set
            {
                _phonenumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }



        //   string Name;
        // string PhoneNumber;
        bool SendMultiple = false;

        private PhoneNumberChooserTask _ChoosePhoneResult;

        public MainPage()
        {
            InitializeComponent();
            DataContext = this.DataContext;
            //BindContacts();
            _ChoosePhoneResult = new PhoneNumberChooserTask();
            _ChoosePhoneResult.Completed += new EventHandler<PhoneNumberResult>(_ChoosePhoneResult_Completed);
            _ChoosePhoneResult.Show();




            myFeedbackOverlay.VisibilityChanged += myFeedbackOverlay_VisibilityChanged;

            //GetContactslist();
        }

        void myFeedbackOverlay_VisibilityChanged(object sender, EventArgs e)
        {
            ApplicationBar.IsVisible = (myFeedbackOverlay.Visibility != Visibility.Visible);
        }

        void _ChoosePhoneResult_Completed(object sender, PhoneNumberResult e)
        {

            if (e.TaskResult.ToString() == "OK")
            {
                Name = e.DisplayName;
                PhoneNumber = e.PhoneNumber;

                
                //ShowSelectedContact();

            }

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _ChoosePhoneResult.Show();


        }


        /// <summary>
        /// Show Selected Contact
        /// </summary>
        void ShowSelectedContact()
        {
            if (Name != null && PhoneNumber != null)
            {
                shwselectedstk.Visibility = Visibility.Visible;

                txtname.Text = Name;
                txtph.Text = PhoneNumber;
            }

        }

        /// <summary>
        /// Compose Sms to Send
        /// </summary>
        private void composesms()
        {
            SmsComposeTask Sms = new SmsComposeTask();
            Sms.Body += Name;
            Sms.Body += "\n";
            Sms.Body += PhoneNumber;


            prgrsbar.Visibility = Visibility.Collapsed;
            txtprpare.Visibility = Visibility.Collapsed;
            Sms.Show();

        }

        /// <summary>
        /// Compose Email to send
        /// </summary>
        void ComposeEmail()
        {
            EmailComposeTask Mail = new EmailComposeTask();
            Mail.Body += Name;
            Mail.Body += "\n";
            Mail.Body += PhoneNumber;
            Mail.Subject = Name;
            Mail.Show();
        }

        private void btnemail_Click(object sender, EventArgs e)
        {
            ComposeEmail();
        }

        private void btnSms_Click(object sender, EventArgs e)
        {
            composesms();
        }

        private void menubtnaboutus_Click(object sender, EventArgs e)
        {

            MessageBox.Show("\u00a9" + "\n" + DateTime.Now.Year, "KenZone", MessageBoxButton.OK);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myFeedbackOverlay.Reset();
        }


    }
}