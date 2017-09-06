using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFormsTabsMedia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage1 : ContentPage
    {
        public TabPage1()
        {
            InitializeComponent();

            this.Icon = "collections_tab";
            this.Title = "Tab1";
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await Application.Current.MainPage.DisplayAlert("No Camera", "No camera available.", "OK");
                return;
            }

            var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);
            if (cameraStatus != PermissionStatus.Granted)
            {
                var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Camera });
                cameraStatus = results[Permission.Camera];
            }

            if (cameraStatus == PermissionStatus.Granted)
            {
                MediaFile file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    PhotoSize = PhotoSize.Large,
                    AllowCropping = true,
                    Name = "cellar-beer.jpg"
                });

                if (file != null)
                {
                    // post image to server!
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Permissions Denied", "Unable to take photos.", "OK");

                if (Device.RuntimePlatform == Device.iOS)
                {
                    var result = await Application.Current.MainPage.DisplayAlert("Settings", "Update camera permissions?", "Yes", "No");
                    if (result)
                    {
                        CrossPermissions.Current.OpenAppSettings();
                    }
                }
            }
        }
    }
}