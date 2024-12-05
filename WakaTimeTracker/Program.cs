using WakaTime.Shared.ExtensionUtils;

var wakaTime = new WakaTime.Shared.ExtensionUtils.WakaTime(new Metadata(), new Logger());
await wakaTime.InitializeAsync();
wakaTime.TotalTimeTodayUpdated += WakaTime_TotalTimeTodayUpdated;
Console.ReadLine();

void WakaTime_TotalTimeTodayUpdated(object? sender, TotalTimeTodayUpdatedEventArgs e)
{
	Console.WriteLine(e.TotalTimeTodayDetailed);
}

public class Logger : ILogger
{
	public void Debug(string message)
	{
		Console.WriteLine(message);
	}

	public void Error(string message, Exception ex = null)
	{
		Console.WriteLine(message);
	}

	public void Warning(string message)
	{
		Console.WriteLine(message);
	}

	public void Info(string message)
	{
		Console.WriteLine(message);
	}
}