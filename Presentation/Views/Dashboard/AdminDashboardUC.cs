using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.Presentation.Views.Dashboard
{
    using PBOBarberMate.Core.Interfaces;

    public partial class AdminDashboardUC : UserControl, IPageFeature
    {
        public string PageTitle => "BarberMate 2.0";
        private readonly INavigationService _nav;

        public AdminDashboardUC(INavigationService nav)
        {
            InitializeComponent();
            _nav = nav;
        }
    }
}
