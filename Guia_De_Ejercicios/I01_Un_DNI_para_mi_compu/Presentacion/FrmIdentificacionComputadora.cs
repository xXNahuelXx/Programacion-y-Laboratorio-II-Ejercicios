using System.Windows.Forms;
using System.IO;
using System;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = $"Compu de {Environment.UserName}";
            ConfigurarLogoSistemaOperativo();
            this.lblSistemaOperativo.Text = $"Sistema Operativo: {Environment.OSVersion.Platform} {Environment.OSVersion.Version}";
            this.lblNombreMaquina.Text = $"Nombre de la maquina: {Environment.MachineName}";
            ConfigurarArquitectura();
            this.lblCantProcesadores.Text = $"Cant. Procesadores: {Environment.ProcessorCount} procesadores logicos";
            this.lblDirectorioActual.Text = $"Identificacion ejecutada en: {Environment.NewLine}{Environment.CurrentDirectory}";
            ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if(OperatingSystem.IsWindows())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
            else if(OperatingSystem.IsLinux())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            else if(OperatingSystem.IsMacOS())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
        }

        private void ConfigurarArquitectura()
        {
            if(Environment.Is64BitProcess)
            {
                this.lblArquitectura.Text = $"Arquitectura: 64 bits";
            }
            else
            {
                this.lblArquitectura.Text = $"Arquitectura: 32 bits";
            }
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            long espacioTotalBytes = 0;
            long espacioDisponibleBytes = 0;
            double espacioTotal;
            double espacioDisponible;

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                espacioTotalBytes += drive.TotalSize;
                espacioDisponibleBytes += drive.AvailableFreeSpace;
            }

            espacioTotal = Math.Round(espacioTotalBytes * 9.31e-10);
            espacioDisponible = Math.Round(espacioDisponibleBytes * 9.31e-10);

            this.lblEspacioTotal.Text = $"Espacio total: {espacioTotal} Gigabytes";
            this.lblEspacioDisponible.Text = $"Espacio disponible: {espacioDisponible} Gigabytes";
        }
    }
}
