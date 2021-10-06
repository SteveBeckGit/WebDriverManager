using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Roman_Framework.Selenium.WebDriverManager.Models
{
	[XmlRoot(ElementName = "Contents", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
	public class Contents
	{
		[XmlElement(ElementName = "Key", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string Key { get; set; }
		[XmlElement(ElementName = "Generation", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string Generation { get; set; }
		[XmlElement(ElementName = "MetaGeneration", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string MetaGeneration { get; set; }
		[XmlElement(ElementName = "LastModified", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string LastModified { get; set; }
		[XmlElement(ElementName = "ETag", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string ETag { get; set; }
		[XmlElement(ElementName = "Size", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string Size { get; set; }
	}

	[XmlRoot(ElementName = "ListBucketResult", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
	public class ListBucketResult
	{
		[XmlElement(ElementName = "Name", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string Name { get; set; }
		[XmlElement(ElementName = "Prefix", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string Prefix { get; set; }
		[XmlElement(ElementName = "Marker", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string Marker { get; set; }
		[XmlElement(ElementName = "IsTruncated", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public string IsTruncated { get; set; }
		[XmlElement(ElementName = "Contents", Namespace = "http://doc.s3.amazonaws.com/2006-03-01")]
		public List<Contents> Contents { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}
}
