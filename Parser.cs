using System;

public class Class1
{
	public Class1()
	{
		StreamWriter streamwriter = new StreamWriter(@"D:\index.html");
		streamwriter.WriteLine("<html>");
		streamwriter.WriteLine("<head>");
		streamwriter.WriteLine("  <title>HTML-Document</title>");
		streamwriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
		streamwriter.WriteLine("</head>");
		streamwriter.WriteLine("<body>");
		streamwriter.WriteLine("Привет");
		streamwriter.WriteLine("</body>");
		streamwriter.WriteLine("</html>");
		streamwriter.Close();
	}
}
