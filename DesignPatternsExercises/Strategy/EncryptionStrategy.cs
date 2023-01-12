using Common;

namespace DesignPatternsExercises.Strategy
{
    public interface IEncryptionStrategy
    {
        public string Encrypt(string input);
        public string Decrypt(string input);
    }

    public class DESEncryption : IEncryptionStrategy
    {
        public string Decrypt(string input)
        {
            return input.DesDecrypt();
          
        }

        public string Encrypt(string input)
        {
            return input.DesCrypt();
        }
    }

    public class AESEncryption : IEncryptionStrategy
    {
        public string Decrypt(string input)
        {
            return input.AesDecrypt();

        }

        public string Encrypt(string input)
        {
            return input.AesCrypt();
        }
    }
}
