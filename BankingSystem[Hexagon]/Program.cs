using BankingSystem_Hexagon_.auth_module.models;
using BankingSystem_Hexagon_.auth_module.repositories;
using BankingSystem_Hexagon_.auth_module.use_cases;

namespace BankingSystem_Hexagon_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var authRepo = new AuthRepositoryTemp();
            var authUseCase = new AuthUseCase(authRepo);

            try {
               var userId = authUseCase.Login("val", "1111");
                Console.WriteLine(userId);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            
        }
    }
}