using PhysicianHandbook.Application.Events;
using PhysicianHandbook.Application.Models;
using PhysicianHandbook.Application.Models.Enums;
using PhysicianHandbook.Application.Views.Interfaces;
using System.ComponentModel;

namespace PhysicianHandbook.Application.Views;

public partial class DiseaseView : UserControl, IDiseaseView
{
    private List<Medication> _availableMedications = new List<Medication>();
    private BindingList<MedicationDetail> _medicationDetails = new BindingList<MedicationDetail>();

    public event EventHandler<DiseaseEventArgs> AddDiseaseRequested;
    public event EventHandler<DiseaseEventArgs> EditDiseaseRequested;
    public event EventHandler<Guid> DeleteDiseaseRequested;

    public DiseaseView()
    {
        InitializeComponent();
        dataGridViewDiseases.AutoGenerateColumns = false;
        InitializeDataGridViewDiseases();
        InitializeDataGridViewMedicationDetails();

        comboBoxSeverity.DataSource = Enum.GetValues(typeof(Severity));
        comboBoxSeverity.SelectedItem = Severity.Легка;

        var contextMenu = new ContextMenuStrip();
        var editItem = new ToolStripMenuItem("Редагувати");
        var deleteItem = new ToolStripMenuItem("Видалити");
        editItem.Click += EditDisease_Click;
        deleteItem.Click += DeleteDisease_Click;
        contextMenu.Items.AddRange(new ToolStripItem[] { editItem, deleteItem });
        dataGridViewDiseases.ContextMenuStrip = contextMenu;
    }

    private void InitializeDataGridViewDiseases()
    {
        var nameColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Name",
            HeaderText = "Назва",
            ReadOnly = true
        };
        dataGridViewDiseases.Columns.Add(nameColumn);

        var symptomsColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Symptoms",
            HeaderText = "Симптоми",
            ReadOnly = true
        };
        dataGridViewDiseases.Columns.Add(symptomsColumn);

        var proceduresColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Procedures",
            HeaderText = "Процедури",
            ReadOnly = true
        };
        dataGridViewDiseases.Columns.Add(proceduresColumn);

        var severityColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Severity",
            HeaderText = "Тяжкість",
            ReadOnly = true
        };
        dataGridViewDiseases.Columns.Add(severityColumn);

        var medicationsColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "MedicationsSummary",
            HeaderText = "Медикаменти",
            ReadOnly = true
        };
        dataGridViewDiseases.Columns.Add(medicationsColumn);
    }

    private void InitializeDataGridViewMedicationDetails()
    {
        dataGridViewMedicationDetails.AutoGenerateColumns = false;
        dataGridViewMedicationDetails.DataSource = _medicationDetails;

        var medicationNameColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "MedicationName",
            HeaderText = "Медикамент",
            ReadOnly = true
        };
        dataGridViewMedicationDetails.Columns.Add(medicationNameColumn);

        var quantityColumn = new DataGridViewTextBoxColumn
        {
            DataPropertyName = "Quantity",
            HeaderText = "Кількість"
        };
        dataGridViewMedicationDetails.Columns.Add(quantityColumn);

        var unitColumn = new DataGridViewComboBoxColumn
        {
            DataPropertyName = "Unit",
            HeaderText = "Одиниця",
            DataSource = Enum.GetValues(typeof(UnitType)),
            FlatStyle = FlatStyle.Flat
        };
        dataGridViewMedicationDetails.Columns.Add(unitColumn);
    }

    public void LoadAvailableMedications(List<Medication> medications)
    {
        _availableMedications = medications;
        listBoxMedications.DataSource = _availableMedications;
        listBoxMedications.DisplayMember = "Name";
        listBoxMedications.ValueMember = "Id";
    }

    public void SetDiseases(List<Disease> diseases)
    {
        dataGridViewDiseases.DataSource = null;
        dataGridViewDiseases.DataSource = diseases;
    }
    public void ClearInputFields()
    {
        textBoxName.Clear();
        textBoxSymptoms.Clear();
        textBoxProcedures.Clear();
        _medicationDetails.Clear();
    }
    private void buttonAddMedication_Click(object sender, EventArgs e)
    {
        var selectedMedications = listBoxMedications.SelectedItems.Cast<Medication>().ToList();
        foreach (var med in selectedMedications)
        {
            if (!_medicationDetails.Any(m => m.Medication.Id == med.Id))
            {
                var detail = new MedicationDetail
                {
                    Medication = med,
                    Quantity = 1,
                    Unit = UnitType.Шт
                };
                _medicationDetails.Add(detail);
            }
        }
    }

    private void buttonSaveDisease_Click(object sender, EventArgs e)
    {
        var name = textBoxName.Text.Trim();
        var symptoms = textBoxSymptoms.Text.Trim();
        var procedures = textBoxProcedures.Text.Trim();
        var severity = (Severity)comboBoxSeverity.SelectedItem;

        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("Введіть назву хвороби.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_medicationDetails.Count == 0)
        {
            MessageBox.Show("Додайте хоча б один медикамент.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var newDisease = new Disease
        {
            Name = name,
            Symptoms = symptoms,
            Procedures = procedures,
            Severity = severity,
            Medications = _medicationDetails.ToList()
        };

        AddDiseaseRequested?.Invoke(this, new DiseaseEventArgs { Disease = newDisease });

        ClearInputFields();

        MessageBox.Show("Хворобу успішно додано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void buttonRemoveMedication_Click(object sender, EventArgs e)
    {
        if (dataGridViewMedicationDetails.SelectedRows.Count > 0)
        {
            var selectedDetail = dataGridViewMedicationDetails.SelectedRows[0].DataBoundItem as MedicationDetail;
            if (selectedDetail != null)
            {
                var result = MessageBox.Show($"Ви впевнені, що хочете видалити медикамент '{selectedDetail.Medication.Name}'?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _medicationDetails.Remove(selectedDetail);
                }
            }
        }
        else
        {
            MessageBox.Show("Будь ласка, виберіть медикамент для видалення.", "Немає вибору", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


    private void EditDisease_Click(object sender, EventArgs e)
    {
        if (dataGridViewDiseases.SelectedRows.Count > 0)
        {
            var selectedDisease = dataGridViewDiseases.SelectedRows[0].DataBoundItem as Disease;
            if (selectedDisease != null)
            {
                using (var editForm = new EditDiseaseForm(selectedDisease, _availableMedications))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        var editedDisease = editForm.Disease;
                        EditDiseaseRequested?.Invoke(this, new DiseaseEventArgs { Disease = editedDisease });
                    }
                }
            }
        }
    }

    private void DeleteDisease_Click(object sender, EventArgs e)
    {
        if (dataGridViewDiseases.SelectedRows.Count > 0)
        {
            var selectedDisease = dataGridViewDiseases.SelectedRows[0].DataBoundItem as Disease;
            if (selectedDisease != null)
            {
                var result = MessageBox.Show($"Ви впевнені, що хочете видалити хворобу '{selectedDisease.Name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteDiseaseRequested?.Invoke(this, selectedDisease.Id);
                }
            }
        }
    }
}