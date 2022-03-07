public class Faculty extends Employee
{
	OfficeHours hours;
	String rank;
	Faculty(String First, String Last, int streetNumber, String streetName, String streetSuffix, long phoneNumber,
			String eMail, String office, double salary, int startTime,int endTime,String rank)
	{
		super(First, Last, streetNumber, streetName, streetSuffix, phoneNumber, eMail, office, salary);
		hours = new OfficeHours(startTime,endTime);
		this.rank = rank;
	}
	public String toString()
	{
		String output = super.toString();
		output += String.format("\nOffice Hours: %s\nRank: %s", hours.toString(), rank);
		return output;
	}
}
class OfficeHours
{
	// Time is incremented in Minutes
	int startTime;
	int endTime;
	OfficeHours(int start, int end)
	{
		this.startTime = start;
		this.endTime = end;
	}
	public String toString()
	{
		String output = "";
		output = String.format("%02d:%02d - %02d:%02d",startTime/60,startTime%60,endTime/60,endTime%60);
		
		return output;
	}
}
