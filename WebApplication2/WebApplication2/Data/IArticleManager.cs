using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace WebApplication2.Data
{
    public interface IArticleManager
    {
        Task<int> Create(Article article);
        Task<int> Delete(int Id);
        Task<int> Update(Article article);
        Task<Article> GetById(int Id);
        Task<List<Article>> ListAll(int skip, int take, string orderBy, string direction);
        Task<int> Count();

      
    }
}
