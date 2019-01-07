using LooppieMobileApp.Model;
using LooppieMobileApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LooppieMobileApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExplorePage : ContentPage
	{
        public ExplorePageViewModel _explorePageVm;

        public Question TheQuestion { get; set; }

        public List<Question> Questions { get; set; }
        private int _index;
        public ExplorePage ()
		{
            _explorePageVm = new ExplorePageViewModel();
            Questions = _explorePageVm.Questions;
            TheQuestion = Questions[_index];
            BindingContext = TheQuestion;
            InitializeComponent ();
		}
	}
}