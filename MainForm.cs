using FaceCensorApp.AI.Services;
using FaceCensorApp.Application.Services;
using FaceCensorApp.Domain.Enums;
using FaceCensorApp.Infrastructure.FileSystem;
using System;
using System.Windows.Forms;

namespace FaceCensorApp.WinForms;

public partial class MainForm : Form
{
    private readonly MediaProcessingService _mediaProcessingService;

    public MainForm()
    {
        InitializeComponent();
        LoadCensorModes();

        var scanner = new MediaScanner();
        var detector = new StubFaceDetector();
        _mediaProcessingService = new MediaProcessingService(scanner, detector);
    }

    private void LoadCensorModes()
    {
        cboCensorMode.DataSource = Enum.GetValues(typeof(CensorMode));
    }

    private void btnBrowseFolder_Click(object sender, EventArgs e)
    {
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        {
            txtRootPath.Text = folderBrowserDialog1.SelectedPath;
        }
    }

    private void btnScan_Click(object sender, EventArgs e)
    {
        lstMediaFiles.Items.Clear();

        var rootPath = txtRootPath.Text.Trim();

        if (string.IsNullOrWhiteSpace(rootPath))
        {
            MessageBox.Show("Selecione uma pasta primeiro.");
            return;
        }

        var files = _mediaProcessingService.ScanMedia(rootPath, chkIncludeSubfolders.Checked);

        foreach (var file in files)
        {
            var tipo = file.IsImage ? "[IMG]" : "[VID]";
            lstMediaFiles.Items.Add($"{tipo} {file.RelativePath}");
        }

        MessageBox.Show($"{files.Count} arquivo(s) encontrado(s).");
    }
}