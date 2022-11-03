using Microsoft.JSInterop;

namespace Network.Browser;
public class Infomation :Network.Infomation, IAsyncDisposable
{
    public event Action Change = null!;
    public event Action Ready = null!;
    private Status _Status = Status.GettingInfomation;
    public Status Status {
        get => _Status;
        private set {
            if (value == _Status) return;
            _Status = value;
            this.Change?.Invoke();
        }
    }

    private IJSObjectReference Module { get; set; } = null!;
    public async ValueTask DisposeAsync()
    {
        if(this.Module is not null)
            await this.Module.DisposeAsync();
        if(this.ObjectReference is not null)
            ObjectReference.Dispose();
    }
    private DotNetObjectReference<Infomation> ObjectReference { get; set; } = null!;
    public Infomation(IJSRuntime jsRuntime) => _ = Constructor(jsRuntime).ConfigureAwait(false);
    private async Task Constructor(IJSRuntime jsRuntime) {
        this.Module = await jsRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/Network.Browser/JsInterop.js");
        this._Status = (await this.Module.InvokeAsync<bool>("Constructor",this.ObjectReference = DotNetObjectReference.Create(this))) ? Status.Online : Status.Offline;
        this.Ready?.Invoke();
    }
    [JSInvokable]
    public void Online()=>Status= Status.Online;
    [JSInvokable]
    public void Offline()=>Status= Status.Offline;
}
