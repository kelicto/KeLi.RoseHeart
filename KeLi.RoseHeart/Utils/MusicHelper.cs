using NAudio.Wave;

namespace KeLi.RoseHeart.Utils
{
    public class MusicHelper
    {
        private readonly string _filePath;

        public MusicHelper(string filePath)
        {
            _filePath = filePath;
        }

        public void PlayMusic()
        {
            var waveOutDevice = new WaveOut();
            var audioFileReader = new AudioFileReader(_filePath);

            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }
    }
}