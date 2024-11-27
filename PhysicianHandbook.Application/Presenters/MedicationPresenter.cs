using PhysicianHandbook.Application.Events;
using PhysicianHandbook.Application.Models;
using PhysicianHandbook.Application.Services.Interfaces;
using PhysicianHandbook.Application.Views.Interfaces;

namespace PhysicianHandbook.Application.Presenters;

public class MedicationPresenter : BasePresenter<IMedicationView, Medication>
{
    public event EventHandler MedicationUpdated;

    public MedicationPresenter(IMedicationView view, IDataService dataService)
        : base(view, dataService)
    {
    }

    protected override void Initialize()
    {
        _view.AddMedicationRequested += OnAddMedicationRequested;
        _view.DeleteMedicationRequested += OnDeleteMedicationRequested;
        _view.EditMedicationRequested += OnEditMedicationRequested;

        LoadModelsAsync();
    }

    protected override async Task<List<Medication>> GetModelsAsync()
    {
        return await _dataService.GetMedicationsAsync();
    }

    protected override async Task SaveModelsAsync(List<Medication> models)
    {
        await _dataService.SaveMedicationsAsync(models);
    }

    protected override void SetModelsInView(List<Medication> models)
    {
        _view.SetMedications(models);
    }

    private async void OnAddMedicationRequested(object sender, MedicationEventArgs e)
    {
        e.Medication.Id = Guid.NewGuid();
        await AddModelAsync(e.Medication);

        MedicationUpdated?.Invoke(this, EventArgs.Empty);
    }

    private async void OnEditMedicationRequested(object sender, MedicationEventArgs e)
    {
        await UpdateModelAsync(e.Medication);

        MedicationUpdated?.Invoke(this, EventArgs.Empty);
    }

    private async void OnDeleteMedicationRequested(object sender, Guid id)
    {
        await DeleteModelAsync(id);

        MedicationUpdated?.Invoke(this, EventArgs.Empty);
    }

    public override async Task UpdateModelAsync(Medication medication)
    {
        var medications = await GetModelsAsync();
        var index = medications.FindIndex(m => m.Id == medication.Id);

        if (index != -1)
        {
            medications[index].Name = medication.Name;
            medications[index].Stock = medication.Stock;
            medications[index].Price = medication.Price;
            medications[index].Alternatives = medication.Alternatives;

            await SaveModelsAsync(medications);
            SetModelsInView(medications);
        }
    }

    public override async Task DeleteModelAsync(Guid id)
    {
        var medications = await GetModelsAsync();
        medications.RemoveAll(m => m.Id == id);

        foreach (var med in medications)
        {
            med.Alternatives.RemoveAll(a => a.Id == id);
        }

        await SaveModelsAsync(medications);
        SetModelsInView(medications);
    }
}