class FDHandling
{
	// File IO
	public void CreateFile()
	{
		var folderPath = @"netLearning-SmritiA/FirstConsoleApp/G.FileIO";
		var filePath = $"{folderPath}\\student.txt";
		
		File.WriteAllText(filePath, "This is first line of text");
		
		Directory.CreateDirectory($"{folderPath}\\Dummy");
		
		//10 files wit names File1.cs, File2.cs and so on.
		// each should contain a byte variable 'age' with value 1,2,3.
		
		for (int counter = 1 ; counter <= 10; counter++)
		{
			var fileP = $"{folderPath}\\Dummy\\File{counter}.cs";
		}
	}
}