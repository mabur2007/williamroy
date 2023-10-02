namespace Tracker.UI.App.Data
{
    public class PatchService
    {
        public async Task<PatchDTO[]> GetPatchesAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetFromJsonAsync<PatchDTO[]>("https://localhost:7164/Patch");
            Console.WriteLine(response.Length);
            return response;
        }
    }

}
