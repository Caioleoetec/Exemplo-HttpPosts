using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHttp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExemploHttp.ViewModels
{
    public class PostsViewModel:ObservableObject
    {
        [ObservableProperty]
        private List<Post> posts;

    }
}
