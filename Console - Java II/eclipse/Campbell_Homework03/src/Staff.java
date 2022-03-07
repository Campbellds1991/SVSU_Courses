public class Staff extends Employee
{
	private String title;
	Staff(String First, String Last, int streetNumber, String streetName, String streetSuffix, long phoneNumber,
			String eMail, String office, double salary, String title)
	{
		super(First, Last, streetNumber, streetName, streetSuffix, phoneNumber, eMail, office, salary);
		this.title = title;
	}
	public String toString()
	{
		String output = super.toString();
		output += String.format("\nTitle: %s", title);
		return output;
	}
		
}
