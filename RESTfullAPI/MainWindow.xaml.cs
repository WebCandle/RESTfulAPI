using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;

namespace RESTfullAPI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnSend.IsEnabled = false;
            if(rdGet.IsChecked == true)
            {
                StartGet();
            }
            else if(rdPost.IsChecked == true)
            {
                StartPost();
            }
            else if(rdPut.IsChecked == true)
            {
                StartPut();
            }
            
        }
        private async void StartGet()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage httpResponse = await client.GetAsync(txtUri.Text + "?" + txtParameters.Text);
                if(httpResponse.IsSuccessStatusCode)
                {
                    txtResponse.Text = await httpResponse.Content.ReadAsStringAsync();
                }
                else
                {
                    MessageBox.Show("Internal server Error");
                }
                btnSend.IsEnabled = true;
            }
        }
        private async void StartPost()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage httpResponse = await client.PostAsync(txtUri.Text, new StringContent(txtParameters.Text));
                if (httpResponse.IsSuccessStatusCode)
                {
                    txtResponse.Text = await httpResponse.Content.ReadAsStringAsync();
                }
                else
                {
                    MessageBox.Show("Internal server Error");
                }
                btnSend.IsEnabled = true;
            }
        }
        private async void StartPut()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage httpResponse = await client.PutAsync(txtUri.Text , new StringContent(txtParameters.Text));
                if (httpResponse.IsSuccessStatusCode)
                {
                    txtResponse.Text = await httpResponse.Content.ReadAsStringAsync();
                }
                else
                {
                    MessageBox.Show("Internal server Error");
                }
                btnSend.IsEnabled = true;
            }
        }
    }
}
