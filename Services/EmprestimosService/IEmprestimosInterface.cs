using System.Data;
using BibliotecaDoHass.Models;

namespace BibliotecaDoHass.Services.EmprestimosService
{
    public interface IEmprestimosInterface
    {
        Task<DataTable> BuscaDadosEmprestimoExcel();
        Task<ResponseModel<List<EmprestimosModel>>> BuscarEmprestimos();
        Task<ResponseModel<EmprestimosModel>> BuscarEmprestimosPorId (int? id);
        Task<ResponseModel<EmprestimosModel>> CadastrarEmprestimo(EmprestimosModel emprestimosModel);
        Task<ResponseModel<EmprestimosModel>> EditarEmprestimo(EmprestimosModel emprestimosModel);
        Task<ResponseModel<EmprestimosModel>> ExcluirEmprestimo(EmprestimosModel emprestimosModel);
    }
}
