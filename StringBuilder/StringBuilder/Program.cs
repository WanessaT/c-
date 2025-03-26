
using StringBuild.Entities;

namespace StringBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment("Faça uma boa viagem.");
            Comment comment2 = new Comment("Uau, isso é incrível!");
            Post post1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Viajando para a Nova Zelândia",
                "Vou visitar esse país maravilhoso",
                12
                );
            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Boa noite.");
            Comment comment4 = new Comment("Que a força esteja com você");
            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Boa noite pessoal",
                "Vejo vocês amanhã.",
                5
                );
            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}