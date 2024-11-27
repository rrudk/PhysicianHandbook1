using PhysicianHandbook.Application.Events;
using PhysicianHandbook.Application.Models;
using PhysicianHandbook.Application.Services.Interfaces;
using PhysicianHandbook.Application.Views.Interfaces;
using Timer = System.Windows.Forms.Timer;

namespace PhysicianHandbook.Application.Presenters;

public class DiseasePresenter : BasePresenter<IDiseaseView, Disease>, IDisposable
{
    private readonly Timer _medicationUpdateTimer;

    public event EventHandler DiseaseUpdated;

    public DiseasePresenter(IDiseaseView view, IDataService dataService)
        : base(view, dataService)
    {
        _medicationUpdateTimer = new Timer();
        _medicationUpdateTimer.Interval = 5000;
        _medicationUpdateTimer.Tick += OnMedicationUpdateTimerTick;
        _medicationUpdateTimer.Start();
    }

    protected override void Initialize()
    {
        _view.AddDiseaseRequested += OnAddDiseaseRequested;
        _view.EditDiseaseRequested += OnEditDiseaseRequested;
        _view.DeleteDiseaseRequested += OnDeleteDiseaseRequested;

        LoadAvailableMedications();
        LoadModelsAsync();
    }

    protected override async Task<List<Disease>> GetModelsAsync()
    {
        return await _dataService.GetDiseasesAsync();
    }

    protected override async Task SaveModelsAsync(List<Disease> models)
    {
        await _dataService.SaveDiseasesAsync(models);
    }

    protected override void SetModelsInView(List<Disease> models)
    {
        _view.SetDiseases(models);
    }

    private async void OnAddDiseaseRequested(object sender, DiseaseEventArgs e)
    {
        e.Disease.Id = Guid.NewGuid();
        await AddModelAsync(e.Disease);

        DiseaseUpdated?.Invoke(this, EventArgs.Empty);
    }

    private async void OnEditDiseaseRequested(object sender, DiseaseEventArgs e)
    {
        await UpdateModelAsync(e.Disease);

        DiseaseUpdated?.Invoke(this, EventArgs.Empty);
    }

    private async void OnDeleteDiseaseRequested(object sender, Guid id)
    {
        await DeleteModelAsync(id);

        DiseaseUpdated?.Invoke(this, EventArgs.Empty);
    }

    private async void OnMedicationUpdateTimerTick(object sender, EventArgs e)
    {
        await LoadAvailableMedications();
    }

    private async Task LoadAvailableMedications()
    {
        var medications = await _dataService.GetMedicationsAsync();
        _view.LoadAvailableMedications(medications);
    }

    public override async Task UpdateModelAsync(Disease disease)
    {
        var diseases = await GetModelsAsync();
        var index = diseases.FindIndex(d => d.Id == disease.Id);

        if (index != -1)
        {
            diseases[index].Name = disease.Name;
            diseases[index].Symptoms = disease.Symptoms;
            diseases[index].Procedures = disease.Procedures;
            diseases[index].Severity = disease.Severity;
            diseases[index].Medications = disease.Medications;

            await SaveModelsAsync(diseases);
            SetModelsInView(diseases);
        }
    }

    // Метод для очистки ресурсов
    public void Dispose()
    {
        _medicationUpdateTimer?.Stop();
        _medicationUpdateTimer?.Dispose();
    }
}