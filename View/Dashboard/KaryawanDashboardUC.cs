using PBOBarberMate.App.Services;
using PBOBarberMate.View.Homepages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOBarberMate.View.Dashboard
{
    public partial class KaryawanDashboardUC : UserControl
    {
    private readonly AkunService _akunService;
    private readonly SessionService _sessionService;
    private readonly MainApp _mainApp; // Referensi ke MainApp untuk navigasi global
    private readonly HomepageKaryawanUC _homepageKaryawanUC;
        public KaryawanDashboardUC(AkunService akunService, SessionService sessionService, MainApp mainApp, HomepageKaryawanUC homepageKaryawanUC)
        {
            InitializeComponent();

            _akunService = akunService;
            _sessionService = sessionService;
            _mainApp = mainApp;
            _homepageKaryawanUC = homepageKaryawanUC;
        }
    }
}
