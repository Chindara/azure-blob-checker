// Local file to upload
string uploadFilePath = @"C:\Files\IMG_9952.JPG";

string container = "claims";

// Name of the file in Blob
string blobName = Path.GetFileName(uploadFilePath);

IAzureBlobService azureBlobService = new AzureBlobService();

// // Upload file to Azure Blob Storage--------------------------
// using FileStream uploadFileStream = File.OpenRead(uploadFilePath);

// Console.WriteLine("Uploading...");
// await azureBlobService.UploadFileAsync(container, blobName, uploadFileStream);
// Console.WriteLine("Upload completed!");

// uploadFileStream.Close();
// //------------------------------------------------------------

// // Download file from Azure Blob Storage----------------------
// string downloadFilePath = @"C:\Files\Downloaded_IMG_9952.JPG";
// Console.WriteLine("Downloading...");
// Stream fileStream = await azureBlobService.DownloadFileAsync(container, blobName);
// using (var file = File.Create(downloadFilePath))
// {
//     await fileStream.CopyToAsync(file);
// }
// Console.WriteLine("File downloaded successfully!");
// fileStream.Close();
// //------------------------------------------------------------

// // View file URI from Azure Blob Storage----------------------
// Console.WriteLine("Generating view URI...");
// Uri fileUri = await azureBlobService.ViewFileAsync(container, blobName);
// Console.WriteLine($"File URI: {fileUri}");
// //------------------------------------------------------------

// // Delete file from Azure Blob Storage------------------------
// Console.WriteLine("Deleting file...");
// await azureBlobService.DeleteFileAsync(container, blobName);
// Console.WriteLine("File deleted successfully!");
// //------------------------------------------------------------

// // Check if blob exists in Azure Blob Storage------------------
// Console.WriteLine("Checking if blob exists...");
// bool exists = await azureBlobService.BlobExistsAsync(container, blobName);
// Console.WriteLine($"Blob exists: {exists}");
// //------------------------------------------------------------