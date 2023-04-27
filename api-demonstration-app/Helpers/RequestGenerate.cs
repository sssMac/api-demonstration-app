using System.Xml;

namespace api_demonstration_app.Helpers
{
    public static class RequestGenerate
    {
        public static string GenerateXmlRequest(
            string oid,
            string documentId,
            string snils,
            string documentName, 
            string mimeType)
        {
            var ns = "urn://mpkey.gosuslugi.ru/sign_document/1.0.0";
            var xmlDoc = new XmlDocument();
            var signExpiration = DateTimeOffset.Now.AddHours(24).ToString();

            // Создание элементов XML
            var SignRequestElement = xmlDoc.CreateElement("ns", "SignRequest", ns);
            var OIDElement = xmlDoc.CreateElement("ns", "OID", ns);
            var SnilsElement = xmlDoc.CreateElement("ns", "Snils", ns);
            var DocumentElement = xmlDoc.CreateElement("ns", "Document", ns);
            var DocumentIdElement = xmlDoc.CreateElement("ns", "DocumentId", ns);
            var MimeTypeElement = xmlDoc.CreateElement("ns", "MimeType", ns);
            var DescriptionElement = xmlDoc.CreateElement("ns", "Description", ns);
            var BacklinkElement = xmlDoc.CreateElement("ns", "Backlink", ns);
            var SignExpirationElement = xmlDoc.CreateElement("ns", "SignExpiration", ns);
            var AttributeElement1 = xmlDoc.CreateElement("ns", "Attribute", ns);
            var AttributeElement2 = xmlDoc.CreateElement("ns", "Attribute", ns);
            var AttributeElement3 = xmlDoc.CreateElement("ns", "Attribute", ns);
            var AttributeNameElement1 = xmlDoc.CreateElement("ns", "AttributeName", ns);
            var AttributeNameElement2 = xmlDoc.CreateElement("ns", "AttributeName", ns);
            var AttributeNameElement3 = xmlDoc.CreateElement("ns", "AttributeName", ns);
            var AttributeValueElement1 = xmlDoc.CreateElement("ns", "AttributeValue", ns);
            var AttributeValueElement2 = xmlDoc.CreateElement("ns", "AttributeValue", ns);
            var AttributeValueElement3 = xmlDoc.CreateElement("ns", "AttributeValue", ns);

            // Установка текстового значения элементов
            OIDElement.InnerText = oid;
            SnilsElement.InnerText = snils;
            DocumentIdElement.InnerText = documentId;
            MimeTypeElement.InnerText = mimeType;
            DescriptionElement.InnerText = documentName;
            BacklinkElement.InnerText = "https://lk.gosuslugi.ru/notifications";
            SignExpirationElement.InnerText = signExpiration;
            AttributeNameElement1.InnerText = "mnemonics";
            AttributeValueElement1.InnerText = "MNSV03";
            AttributeNameElement2.InnerText = "serviceName";
            AttributeValueElement2.InnerText = "Отправка документов на подпись в «Госключ";
            AttributeNameElement3.InnerText = "orgName";
            AttributeValueElement3.InnerText = "ООО \"СИМЭНЕРГО\"";

            // Добавление элементов в иерархию документа
            AttributeElement1.AppendChild(AttributeNameElement1);
            AttributeElement1.AppendChild(AttributeValueElement1);
            AttributeElement2.AppendChild(AttributeNameElement2);
            AttributeElement2.AppendChild(AttributeValueElement2);
            AttributeElement3.AppendChild(AttributeNameElement3);
            AttributeElement3.AppendChild(AttributeValueElement3);
            DocumentElement.AppendChild(DocumentIdElement);
            DocumentElement.AppendChild(MimeTypeElement);
            DocumentElement.AppendChild(DescriptionElement);
            DocumentElement.AppendChild(BacklinkElement);
            DocumentElement.AppendChild(SignExpirationElement);
            DocumentElement.AppendChild(AttributeElement1);
            DocumentElement.AppendChild(AttributeElement2);
            DocumentElement.AppendChild(AttributeElement3);
            SignRequestElement.AppendChild(OIDElement);
            SignRequestElement.AppendChild(SnilsElement);
            SignRequestElement.AppendChild(DocumentElement);
            xmlDoc.AppendChild(SignRequestElement);

            return xmlDoc.OuterXml;
        }

        public static string GenerateXmltest()
        {
            var ns = "urn://mpkey.gosuslugi.ru/sign_document/1.0.0";
            var xmlDoc = new XmlDocument();

            // Создание элементов XML
            var SignRequestElement = xmlDoc.CreateElement("ns", "SignRequest", ns);
            var OIDElement = xmlDoc.CreateElement("ns", "OID", ns);
            var SnilsElement = xmlDoc.CreateElement("ns", "Snils", ns);
            var DocumentElement = xmlDoc.CreateElement("ns", "Document", ns);
            var DocumentIdElement = xmlDoc.CreateElement("ns", "DocumentId", ns);
            var MimeTypeElement = xmlDoc.CreateElement("ns", "MimeType", ns);
            var DescriptionElement = xmlDoc.CreateElement("ns", "Description", ns);
            var BacklinkElement = xmlDoc.CreateElement("ns", "Backlink", ns);
            var SignExpirationElement = xmlDoc.CreateElement("ns", "SignExpiration", ns);
            var AttributeElement1 = xmlDoc.CreateElement("ns", "Attribute", ns);
            var AttributeElement2 = xmlDoc.CreateElement("ns", "Attribute", ns);
            var AttributeElement3 = xmlDoc.CreateElement("ns", "Attribute", ns);
            var AttributeNameElement1 = xmlDoc.CreateElement("ns", "AttributeName", ns);
            var AttributeNameElement2 = xmlDoc.CreateElement("ns", "AttributeName", ns);
            var AttributeNameElement3 = xmlDoc.CreateElement("ns", "AttributeName", ns);
            var AttributeValueElement1 = xmlDoc.CreateElement("ns", "AttributeValue", ns);
            var AttributeValueElement2 = xmlDoc.CreateElement("ns", "AttributeValue", ns);
            var AttributeValueElement3 = xmlDoc.CreateElement("ns", "AttributeValue", ns);

            // Установка текстового значения элементов
            OIDElement.InnerText = "1000550738";
            SnilsElement.InnerText = "000-729-729 38";
            DocumentIdElement.InnerText = "1896644961";
            MimeTypeElement.InnerText = "application/pdf";
            DescriptionElement.InnerText = "Документ1";
            BacklinkElement.InnerText = "https://lk.gosuslugi.ru/notifications";
            SignExpirationElement.InnerText = "2022-04-28T17:22:00.000+03:00";
            AttributeNameElement1.InnerText = "mnemonics";
            AttributeValueElement1.InnerText = "MNSV03";
            AttributeNameElement2.InnerText = "serviceName";
            AttributeValueElement2.InnerText = "Отправка документов на подпись в «Госключ";
            AttributeNameElement3.InnerText = "orgName";
            AttributeValueElement3.InnerText = "ООО \"СИМЭНЕРГО\"";

            // Добавление элементов в иерархию документа
            AttributeElement1.AppendChild(AttributeNameElement1);
            AttributeElement1.AppendChild(AttributeValueElement1);
            AttributeElement2.AppendChild(AttributeNameElement2);
            AttributeElement2.AppendChild(AttributeValueElement2);
            AttributeElement3.AppendChild(AttributeNameElement3);
            AttributeElement3.AppendChild(AttributeValueElement3);
            DocumentElement.AppendChild(DocumentIdElement);
            DocumentElement.AppendChild(MimeTypeElement);
            DocumentElement.AppendChild(DescriptionElement);
            DocumentElement.AppendChild(BacklinkElement);
            DocumentElement.AppendChild(SignExpirationElement);
            DocumentElement.AppendChild(AttributeElement1);
            DocumentElement.AppendChild(AttributeElement2);
            DocumentElement.AppendChild(AttributeElement3);
            SignRequestElement.AppendChild(OIDElement);
            SignRequestElement.AppendChild(SnilsElement);
            SignRequestElement.AppendChild(DocumentElement);
            xmlDoc.AppendChild(SignRequestElement);

            return xmlDoc.OuterXml;
        }
    }
}
