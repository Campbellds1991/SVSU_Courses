public class Employee extends Person
{
	String office;
	double salary;
	Employee(String First, String Last, int streetNumber, String streetName, String streetSuffix, long phoneNumber,
			String eMail,String office,double salary)
	{
		super(First, Last, streetNumber, streetName, streetSuffix, phoneNumber, eMail);
		this.office = office;
		this.salary = salary;
	}
	public String toString()
	{
		String output = super.toString();
		output += String.format("\nOffice Location: %s\nSalary: $%,.02f", office, salary);
		return output;
	}
	
}