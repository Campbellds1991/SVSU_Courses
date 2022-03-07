public class Test
	{
	public static void main(String[] args)
		{
		
		
			Student student = new Student("Devin","Campbell",111,"main","st.",1234567890L,"student@svsu.edu",ClassLevel.SOPHOMORE);					
			Person person = new Person("Devin","Campbell",111,"main","st.", 1234567890L,"Person@svsu.edu");
			Employee employee = new Employee("Devin","Campbell",111,"main","st.", 1234567890L,"employee@svsu.edu","CS146",50000);
			Staff staff = new Staff("Devin","Campbell",111,"main","st.", 1234567890L,"staff@svsu.edu","CS146",50000,"Professor");
			Faculty faculty = new Faculty("Devin","Campbell",111,"main","st.", 1234567890L,"faculty@svsu.edu","CS146",50000,480, 990, "El Capitan");

			
			System.out.println("~~Person~~");
			System.out.println(person.toString());
			System.out.println("\n~~Student~~");
			System.out.println(student.toString());			
			System.out.println("\n~~Employee~~");
			System.out.println(employee.toString());
			System.out.println("\n~~Staff~~");
			System.out.println(staff.toString());
			System.out.println("\n~~Faculty~~");
			System.out.println(faculty.toString()); 
			
		}
		
	}
