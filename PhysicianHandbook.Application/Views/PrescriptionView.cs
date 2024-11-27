using PhysicianHandbook.Application.Events;
using PhysicianHandbook.Application.Models;
using PhysicianHandbook.Application.Models.Enums;
using PhysicianHandbook.Application.Presenters;
using PhysicianHandbook.Application.Services.Interfaces;
using PhysicianHandbook.Application.Views.Interfaces;

namespace PhysicianHandbook.Application.Views;

public partial class PrescriptionView : UserControl, IPrescriptionView
{
    private PrescriptionPresenter _prescriptionPresenter;
    private readonly IDataService _dataService;

    private readonly DiseasePresenter _diseasePresenter;
    private readonly MedicationPresenter _medicationPresenter;

    public event EventHandler<PrescriptionEventArgs> AddPrescriptionRequested;
    public event EventHandler<PrescriptionEventArgs> EditPrescriptionRequested;
    public event EventHandler<Guid> DeletePrescriptionRequested;


    public PrescriptionView(IDataService dataService, DiseasePresenter diseasePresenter, MedicationPresenter medicationPresenter)
    {
        InitializeComponent();
        _dataService = dataService;
        _prescriptionPresenter = new PrescriptionPresenter(this, _dataService);

        _diseasePresenter = diseasePresenter;
        _medicationPresenter = medicationPresenter;

        InitializeDataGridViewPrescriptions();
        InitializeContextMenu();
        LoadMedicationsAndDiseases();

        _diseasePresenter.DiseaseUpdated += OnDiseaseChanged;
        _medicationPresenter.MedicationUpdated += OnMedicationChanged;
    }


    private void InitializeContextMenu()
    {
        var contextMenu = new ContextMenuStrip();
        var viewItem = new ToolStripMenuItem("Переглянути");
        var editItem = new ToolStripMenuItem("Редагувати");
        var deleteItem = new ToolStripMenuItem("Видалити");

        viewItem.Click += ViewPrescription_Click;
        editItem.Click += EditPrescription_Click;
        deleteItem.Click += DeletePrescription_Click;

        contextMenu.Items.AddRange(new ToolStripItem[] { viewItem, editItem, deleteItem });
        dataGridViewPrescriptions.ContextMenuStrip = contextMenu;
    }

    public void SetPrescriptions(List<Prescription> prescriptions)
    {
        dataGridViewPrescriptions.Rows.Clear();

        foreach (var p in prescriptions)
        {
            var rowIndex = dataGridViewPrescriptions.Rows.Add([
                p.PatientFullName,
                p.DiseaseName,
                string.Join(", ", p.AdditionalRecommendations.Select(m => $"{m.Medication.Name} ({m.Quantity} {m.Unit})")),
                p.DateOfIllness.ToShortDateString(),
                p.DateOfRecovery.ToShortDateString(),
                p.DoctorName
            ]);

            dataGridViewPrescriptions.Rows[rowIndex].Tag = p.Id;
        }
    }

    private async void OnDiseaseChanged(object sender, EventArgs e)
    {
        var diseases = await _dataService.GetDiseasesAsync();
        comboBoxDisease.DataSource = null;
        comboBoxDisease.DataSource = diseases;
        comboBoxDisease.DisplayMember = "Name";
        comboBoxDisease.ValueMember = "Id";
    }

    private async void OnMedicationChanged(object sender, EventArgs e)
    {
        var medications = await _dataService.GetMedicationsAsync();
        listBoxAdditionalMedications.DataSource = null;
        listBoxAdditionalMedications.DataSource = medications;
        listBoxAdditionalMedications.DisplayMember = "Name";
        listBoxAdditionalMedications.ValueMember = "Id";
    }

    private async void LoadMedicationsAndDiseases()
    {
        var medications = await _dataService.GetMedicationsAsync();
        var diseases = await _dataService.GetDiseasesAsync();

        comboBoxDisease.DataSource = diseases;
        comboBoxDisease.DisplayMember = "Name";
        comboBoxDisease.ValueMember = "Id";

        listBoxAdditionalMedications.DataSource = medications;
        listBoxAdditionalMedications.DisplayMember = "Name";
        listBoxAdditionalMedications.ValueMember = "Id";
    }

    private async void ButtonSavePrescription_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxPatientFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPatientLastName.Text) ||
                comboBoxDisease.SelectedItem == null ||
                listBoxAdditionalMedications.SelectedItems.Count == 0 ||
                string.IsNullOrWhiteSpace(textBoxDoctorName.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var patientFirstName = textBoxPatientFirstName.Text.Trim();
            var patientLastName = textBoxPatientLastName.Text.Trim();
            var selectedDisease = comboBoxDisease.SelectedItem as Disease;
            var selectedMedications = listBoxAdditionalMedications.SelectedItems.Cast<Medication>().ToList();
            var dateOfIllness = dateTimePickerIllness.Value.Date;
            var dateOfRecovery = dateTimePickerRecovery.Value.Date;
            var doctorName = textBoxDoctorName.Text.Trim();

            if (dateOfRecovery < dateOfIllness)
            {
                MessageBox.Show("Дата одужання не може бути раніше дати захворювання.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newPrescription = new Prescription
            {
                PatientFirstName = patientFirstName,
                PatientLastName = patientLastName,
                Disease = selectedDisease,
                AdditionalRecommendations = selectedMedications.Select(m => new MedicationDetail
                {
                    Medication = m,
                    Quantity = 1,
                    Unit = UnitType.Шт
                }).ToList(),
                DateOfIllness = dateOfIllness,
                DateOfRecovery = dateOfRecovery,
                DoctorName = doctorName
            };

            AddPrescriptionRequested?.Invoke(this, new PrescriptionEventArgs { Prescription = newPrescription });

            ClearInputFields();

            MessageBox.Show("Виписку успішно додано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Виникла помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void ClearInputFields()
    {
        textBoxPatientFirstName.Clear();
        textBoxPatientLastName.Clear();
        comboBoxDisease.SelectedIndex = 0;
        listBoxAdditionalMedications.ClearSelected();
        dateTimePickerIllness.Value = DateTime.Now;
        dateTimePickerRecovery.Value = DateTime.Now.AddDays(7);
        textBoxDoctorName.Clear();
    }

    private async void DeletePrescription_Click(object sender, EventArgs e)
    {
        if (dataGridViewPrescriptions.SelectedRows.Count > 0)
        {
            var selectedRow = dataGridViewPrescriptions.SelectedRows[0];
            var prescriptionId = (Guid)selectedRow.Tag;

            var result = MessageBox.Show("Ви впевнені, що хочете видалити цю виписку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var prescriptions = await _dataService.GetPrescriptionsAsync();
                var prescription = prescriptions.FirstOrDefault(p => p.Id == prescriptionId);
                if (prescription != null)
                {
                    var medications = await _dataService.GetMedicationsAsync();
                    foreach (var medDetail in prescription.AdditionalRecommendations)
                    {
                        var med = medications.FirstOrDefault(m => m.Id == medDetail.Medication.Id);
                        if (med != null)
                        {
                            med.Stock += medDetail.Quantity;
                        }
                    }

                    await _dataService.SaveMedicationsAsync(medications);
                    DeletePrescriptionRequested?.Invoke(this, prescriptionId);

                    SetPrescriptions(prescriptions);

                    MessageBox.Show("Виписку успішно видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        else
        {
            MessageBox.Show("Будь ласка, виберіть виписку для видалення.", "Немає вибору", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private async void ViewPrescription_Click(object sender, EventArgs e)
    {
        if (dataGridViewPrescriptions.SelectedRows.Count > 0)
        {
            var selectedRow = dataGridViewPrescriptions.SelectedRows[0];
            var prescriptionId = (Guid)selectedRow.Tag;

            var prescriptions = await _dataService.GetPrescriptionsAsync();
            var prescription = prescriptions.FirstOrDefault(p => p.Id == prescriptionId);
            if (prescription != null)
            {
                using (var viewForm = new ViewPrescriptionForm(prescription))
                {
                    viewForm.ShowDialog();
                }
            }
        }
    }

    private async void EditPrescription_Click(object sender, EventArgs e)
    {
        if (dataGridViewPrescriptions.SelectedRows.Count > 0)
        {
            var selectedRow = dataGridViewPrescriptions.SelectedRows[0];
            var prescriptionId = (Guid)selectedRow.Tag;

            var prescriptions = await _dataService.GetPrescriptionsAsync();
            var prescription = prescriptions.FirstOrDefault(p => p.Id == prescriptionId);
            if (prescription != null)
            {
                using (var editForm = new EditPrescriptionForm(prescription, await _dataService.GetDiseasesAsync(), await _dataService.GetMedicationsAsync()))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        var editedPrescription = editForm.EditedPrescription;
                        EditPrescriptionRequested?.Invoke(this, new PrescriptionEventArgs { Prescription = editedPrescription });

                        var medications = await _dataService.GetMedicationsAsync();

                        foreach (var oldMedDetail in prescription.AdditionalRecommendations)
                        {
                            if (editedPrescription.AdditionalRecommendations.All(m => m.Medication.Id != oldMedDetail.Medication.Id))
                            {
                                var med = medications.FirstOrDefault(m => m.Id == oldMedDetail.Medication.Id);
                                if (med != null)
                                {
                                    med.Stock += oldMedDetail.Quantity;
                                }
                            }
                        }

                        foreach (var newMedDetail in editedPrescription.AdditionalRecommendations)
                        {
                            var oldMedDetail = prescription.AdditionalRecommendations.FirstOrDefault(m => m.Medication.Id == newMedDetail.Medication.Id);
                            if (oldMedDetail == null)
                            {
                                var med = medications.FirstOrDefault(m => m.Id == newMedDetail.Medication.Id);
                                if (med != null)
                                {
                                    med.Stock -= newMedDetail.Quantity;
                                }
                            }
                            else
                            {
                                if (newMedDetail.Quantity > oldMedDetail.Quantity)
                                {
                                    var med = medications.FirstOrDefault(m => m.Id == newMedDetail.Medication.Id);
                                    if (med != null)
                                    {
                                        med.Stock -= (newMedDetail.Quantity - oldMedDetail.Quantity);
                                    }
                                }
                                else if (newMedDetail.Quantity < oldMedDetail.Quantity)
                                {
                                    var med = medications.FirstOrDefault(m => m.Id == newMedDetail.Medication.Id);
                                    if (med != null)
                                    {
                                        med.Stock += (oldMedDetail.Quantity - newMedDetail.Quantity);
                                    }
                                }
                            }
                        }

                        await _dataService.SaveMedicationsAsync(medications);

                        var updatedPrescriptions = await _dataService.GetPrescriptionsAsync();
                        SetPrescriptions(updatedPrescriptions);

                        MessageBox.Show("Виписку успішно відредаговано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("Будь ласка, виберіть виписку для редагування.", "Немає вибору", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void InitializeDataGridViewPrescriptions()
    {
        dataGridViewPrescriptions.AutoGenerateColumns = false;

        var patientNameColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "PatientFullName",
            HeaderText = "Пацієнт",
            Width = 200,
            ReadOnly = true
        };
        dataGridViewPrescriptions.Columns.Add(patientNameColumn);

        var diseaseColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "DiseaseName",
            HeaderText = "Хвороба",
            Width = 150,
            ReadOnly = true
        };
        dataGridViewPrescriptions.Columns.Add(diseaseColumn);

        var medicationsColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "MedicationsSummary",
            HeaderText = "Медикаменти",
            Width = 250,
            ReadOnly = true
        };
        dataGridViewPrescriptions.Columns.Add(medicationsColumn);

        var dateIllnessColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "DateOfIllness",
            HeaderText = "Дата захворювання",
            Width = 120,
            ReadOnly = true
        };
        dataGridViewPrescriptions.Columns.Add(dateIllnessColumn);

        var dateRecoveryColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "DateOfRecovery",
            HeaderText = "Дата одужання",
            Width = 120,
            ReadOnly = true
        };
        dataGridViewPrescriptions.Columns.Add(dateRecoveryColumn);

        var doctorNameColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "DoctorName",
            HeaderText = "Лікар",
            Width = 150,
            ReadOnly = true
        };
        dataGridViewPrescriptions.Columns.Add(doctorNameColumn);
    }
}