using SpriteSlimmer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SpriteSlimmer
{


    public class AppSettings
    {
        public string SelectedFilePath { get; set; }
        public ColorOptions BackgroundColor { get; set; }
        public bool IsRadioButtonPrevColor1Checked { get; set; }

        public const string SettingsFilePath = "settings.xml";

        // デフォルトコンストラクタ（XMLシリアライゼーションに必要）
        public AppSettings() { }

        // 設定をXMLファイルに保存します。
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
            using (StreamWriter writer = new StreamWriter(SettingsFilePath))
            {
                serializer.Serialize(writer, this);
            }
        }

        // XMLファイルから設定を読み込みます。
        public static AppSettings Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));

            // Check if the settings file exists
            if (!File.Exists(SettingsFilePath))
            {
                // If not, create default settings and save to file
                AppSettings defaultSettings = new AppSettings();
                defaultSettings.Save();
                return defaultSettings;
            }

            using (StreamReader reader = new StreamReader(SettingsFilePath))
            {
                return (AppSettings)serializer.Deserialize(reader);
            }
        }
    }

}
