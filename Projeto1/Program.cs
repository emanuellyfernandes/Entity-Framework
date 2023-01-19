

namespace Projeto1{

    class Program{

        static void Main (string[] args)
        {
            
            using (var context = new DataContext()){

                var user = new User { Name = "Emanuelly", Email = "uhsuhsauh"};

                context.Users.Add(user);
                context.SaveChanges();


                //ler a versão mais atual e atualiza update 
                var user2 = context.Users.FirstOrDefault(x => x.Id == 2);
                user.Name = "Manu";
                user.Email = "aaaaa";

                context.Update(user);
                context.SaveChanges();

                var users3= context.Users; // traz lista de usuarios

                var users4 = context.Users.AsNoTracking.Where(x=>x.Nome.Contains("Emanuelly")).ToList(); // to list sempre no final

                // asNoTracking nao usar com update ou delete, só pra ler na tela usar para melhorar a performace 

                var users5 = context.Users.AsNoTracking.Where(x=>x.Nome.Contains("Emanuelly")).FirstOrDefault(); // tb executa a lista




            }
            

            


        }
    }
}