public interface IAzureBlobService
{
    Task UploadFileAsync(string containerName, string blobName, Stream fileStream);
    Task<Stream> DownloadFileAsync(string containerName, string blobName);
    Task<Uri> ViewFileAsync(string containerName, string blobName);
    Task DeleteFileAsync(string containerName, string blobName);
    Task<bool> BlobExistsAsync(string containerName, string blobName);
}