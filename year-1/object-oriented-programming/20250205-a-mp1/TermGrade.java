import java.io.";

public class TermGrade {
	public static void main(String[] args) {
		double quiz1 = 85, quiz2 = 90, quiz3 = 88;
		double lab1 = 92, lab2 = 87, lab3 = 89;
		double attendance = 95;
		double lecExam = 88;
		double labExam = 91;
		double quizAvg = (quiz1 + quiz2 + quiz3) / 3;
		double labAvg = (lab1 + lab2 + lab3) / 3;
		double term Grade = (quizAvg * 0.30) + (labAvg * 0.20) + (attendance * 0.10) + (((lecExam * 0.60) + (labExam 0.40)) * 0.40);

		System.out.println("Quiz 1: " + quiz1);
		System.out.println("Quiz 2: " + quiz2);
		System.out.println("Quiz 3: " + quiz3);
		System.out.println("Quiz Average: " + quizAvg);
		System.out.println("\nLab Activity 1: " + lab1);
		System.out.println("Lab Activity 2: " + lab2);
		System.out.println("Lab Activity 3: " + lab3);
		System.out.println("Lab Average: " + labAvg);
		System.out.println("\nAttendance: " + attendance);
		System.out.println("Lecture Exam: " + lecExam);
		System.out.println("Laboratory Exam: " + labExam);
		System.out.println("\nTotal Term Grade: " + termGrade);
}
