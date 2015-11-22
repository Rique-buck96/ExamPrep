using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ExamUI
{
    [XmlRoot]
    public class ExamDetails
    {
        private string _unitCode;
        private string _question;
        private string _answer;
        private List<string> _keywords;

        [XmlAttribute]
        public string UnitCode
        {
            get { return _unitCode; }
            set
            {
                if (value == null || _unitCode != value)
                    _unitCode = value;
            }
        }

        [XmlElement]
        public string Question
        {
            get { return _question; }
            set
            {
                if (value == null || _question != value)
                    _question = value;
            }
        }

        [XmlElement]
        public string Answer
        {
            get { return _answer; }
            set
            {
                if (value == null || _answer != value)
                    _answer = value;
            }
        }

        [XmlElement]
        public List<string> Keywords
        {
            get { return _keywords; }
            set
            {
                if (value == null || _keywords != value)
                    _keywords = value;
            }
        }

        /// <summary>
        /// Serializes test variables into xml
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="list"></param>
        public void SaveFile(string fileName, List<ExamDetails> list)
        {
            using (var fStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var serializer = new XmlSerializer(typeof(List<ExamDetails>));
                serializer.Serialize(fStream, this);
            }
        }

        /// <summary>
        /// Reads from XML and deserializes test data
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public ExamDetails LoadFromFile(string fileName, List<ExamDetails> list)
        {
            using (var fStream = new FileStream(fileName, FileMode.Open))
            {
                var deserializer = new XmlSerializer(typeof(List<ExamDetails>));
                return (ExamDetails)deserializer.Deserialize(fStream);
            }
        }
    }
}






