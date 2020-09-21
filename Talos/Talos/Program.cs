namespace Talos {
    internal class Program {
        public static void Main(string[] args) {
            using (var game = new Talos())
                game.Run();
        }
    }
}