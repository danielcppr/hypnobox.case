using System.Net.Http.Json;
using TopArticles.Models;

HttpClient client = new HttpClient { BaseAddress = new Uri("http://hypnocore.api.hypnobox.com.br/teste/api/articles") };
List<string> output = new List<string>();
List<Data> allValidArticles = new List<Data>();
ResponseModel response;
int limit = 12;
int? totalPages = null;
int page = 1;

while (page <= (totalPages ?? 1))
{
    response = await client.GetFromJsonAsync<ResponseModel>($"?page={page}");

    if (totalPages == null)
        totalPages = response.total_pages;

    foreach (var article in response.data)
    {
        if (string.IsNullOrEmpty(article.title) && string.IsNullOrEmpty(article.story_title))
            continue;

        allValidArticles.Add(article);    
    }

    page++;
}

var orderedTopLimitArticles = allValidArticles.OrderByDescending(c => c.num_comments).ThenByDescending(c => !string.IsNullOrEmpty(c.title) ? c.title : c.story_title).Take(limit);
orderedTopLimitArticles.ToList().ForEach(a => output.Add($"{a.num_comments}, {a.title ?? a.story_title}"));
output.ForEach(o => Console.WriteLine(o));






