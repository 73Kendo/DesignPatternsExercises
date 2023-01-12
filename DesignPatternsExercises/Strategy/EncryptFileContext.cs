namespace DesignPatternsExercises.Strategy
{
    public class EncryptFileContext
    {
        private IEncryptionStrategy _strategy;

        public EncryptFileContext(IEncryptionStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IEncryptionStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void EncryptFile(string path, string output)
        {
            var content = File.ReadAllText(path);
            File.WriteAllText(output, _strategy.Encrypt(content));
        }

        public void DecryptFile(string path, string output)
        {
            var content = File.ReadAllText(path);
            File.WriteAllText(output, _strategy.Decrypt(content));
        }
    }
}
