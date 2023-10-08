using System.Reactive.Disposables;

namespace MauiTest.ViewModels;
internal class ViewModelBase :BindableObject,IDisposable
{
	private CompositeDisposable? _compositeDisposable;

	/// <summary>
	/// まとめてDispose
	/// </summary>
	public CompositeDisposable CompositeDisposable
    {
        get
        {
            return this._compositeDisposable ??= new CompositeDisposable();
        }
    }

    /// <summary>
    /// Dispose
    /// </summary>
    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Dispose
    /// </summary>
    /// <param name="disposing">マネージドリソースの破棄を行うかどうか</param>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            this._compositeDisposable?.Dispose();
        }
    }
}
