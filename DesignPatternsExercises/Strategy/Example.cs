namespace DesignPatternsExercises.Strategy
{
    public static class Example
    {
        public static void Run()
        {
            var encryptFile = new EncryptFileContext(new DESEncryption());

            encryptFile.EncryptFile(Path.Combine(Directory.GetCurrentDirectory(), "Strategy/File/input.txt"), 
                Path.Combine(Directory.GetCurrentDirectory(), "Strategy/File/input.des"));

            encryptFile.DecryptFile(Path.Combine(Directory.GetCurrentDirectory(), "Strategy/File/input.des"),
                Path.Combine(Directory.GetCurrentDirectory(), "Strategy/File/input2.txt"));
        }
    }
}
