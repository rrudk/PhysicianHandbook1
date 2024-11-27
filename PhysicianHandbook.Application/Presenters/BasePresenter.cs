using PhysicianHandbook.Application.Models.Interfaces;
using PhysicianHandbook.Application.Services.Interfaces;

namespace PhysicianHandbook.Application.Presenters;

public abstract class BasePresenter<TView, TModel>
    where TView : class
    where TModel : IIdentifiable
{
    protected readonly TView _view;
    protected readonly IDataService _dataService;

    protected BasePresenter(TView view, IDataService dataService)
    {
        _view = view;
        _dataService = dataService;
        Initialize();
    }

    protected virtual void Initialize()
    {
    }

    protected abstract Task<List<TModel>> GetModelsAsync();
    protected abstract Task SaveModelsAsync(List<TModel> models);
    protected abstract void SetModelsInView(List<TModel> models);

    protected virtual async Task LoadModelsAsync()
    {
        var models = await GetModelsAsync();
        SetModelsInView(models);
    }

    public virtual async Task AddModelAsync(TModel model)
    {
        var models = await GetModelsAsync();
        models.Add(model);
        await SaveModelsAsync(models);
        SetModelsInView(models);
    }

    public virtual async Task UpdateModelAsync(TModel model)
    {
        var models = await GetModelsAsync();
        var index = models.FindIndex(m => m.Id == model.Id);

        if (index != -1)
        {
            models[index] = model;
            await SaveModelsAsync(models);
            SetModelsInView(models);
        }
    }

    public virtual async Task DeleteModelAsync(Guid id)
    {
        var models = await GetModelsAsync();
        var model = models.FirstOrDefault(m => m.Id == id);

        if (model != null)
        {
            models.Remove(model);
            await SaveModelsAsync(models);
            SetModelsInView(models);
        }
    }
}