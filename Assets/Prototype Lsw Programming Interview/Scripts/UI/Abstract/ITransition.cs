using System.Threading.Tasks;
namespace PrototypeLSWProgrammingInterview.UI.Abstract
{
    public interface ITransition
    {
        Task In();
        Task Out();
    }
}