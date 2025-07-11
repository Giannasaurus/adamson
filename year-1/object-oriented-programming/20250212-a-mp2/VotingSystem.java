import java.io.*;

public class VotingSystem {
	public static void main(String[] args) throws IOException {
		// user input vars
		String[] name = new String[10];
		String[] block = new String[10];
		int[] yearLvl = new int[10];
		int[] bestBooth = new int[10];
		// vote counters vars
		int booth1=0, booth2=0, booth3=0, booth4=0, booth5=0, booth6=0, booth7=0, booth8=0, booth9=0, booth10=0;
		// top 3 ranking and number of votes vars
		int firstPlace=0, firstHighest=0;
		int secondPlace=0, secondHighest=0;
		int thirdPlace=0, thirdHighest=0;
		// votes by year level vars
		int[] firstYearVotes = new int[10];
		int[] secondYearVotes = new int[10];
		int[] thirdYearVotes = new int[10];
		int[] fourthYearVotes = new int[10];
		// buffer reader
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

		// loop to iterate thru all user input haha
		for(int i=0; i<name.length; i++){

			// assigns names to array
			System.out.print("Enter a name: ");  
			name[i]=br.readLine(); // assigns entered name to array in each iteration name i

			// assigns year levels to array
			System.out.print("Enter year level: ");
			yearLvl[i]=Integer.parseInt(br.readLine());

			// assigns blocks to array
			System.out.print("Enter block: ");
			block[i]=br.readLine();

			// assigns best booths to array 
			System.out.print("Enter best booth (1-10): ");
			bestBooth[i]=Integer.parseInt(br.readLine());

			System.out.print("\n");
		}

		/* best booths contest:
			for loop iterates over the 10 booths and
			assigns each submission to a votes counter */
		for(int i=0; i<bestBooth.length; i++) {
			if (bestBooth[i]==1) booth1++; 
			else if (bestBooth[i]==2) booth2++;
			else if (bestBooth[i]==3) booth3++;
			else if (bestBooth[i]==4) booth4++;
			else if (bestBooth[i]==5) booth5++;
			else if (bestBooth[i]==6) booth6++;
			else if (bestBooth[i]==7) booth7++;
			else if (bestBooth[i]==8) booth8++;
			else if (bestBooth[i]==9) booth9++;
			else if (bestBooth[i]==10) booth10++;
		}

		// booth counters to array to iterate over them in looking for the highest votes
		int[] boothCounter={booth1, booth2, booth3, booth4, booth5, booth6, booth7, booth8, booth9, booth10};

		/* find first place:
		    loops over boothCounter to find highest number of votes
		    keeps assigning a value to firstHighest until it cannot be > firstHighest
		    at the end of the loop, it assigns the current value i to firstPlace +1 */
		for(int i=0; i<boothCounter.length; i++){
			if (boothCounter[i]>firstHighest){
				firstHighest=boothCounter[i]; // firstHighest holds 0 until first value
				firstPlace=i+1; // zero-indexed loop so +1
			}
		}

		// find second place
		for (int i=0; i<boothCounter.length; i++) {
			if (boothCounter[i]>secondHighest&&boothCounter[i]<firstHighest) {
			secondHighest=boothCounter[i];
			secondPlace=i+1;
			}
		}

        		// find third place
       		for (int i=0; i<boothCounter.length; i++) {
			if (boothCounter[i]>thirdHighest&&boothCounter[i]<secondHighest) {
			thirdHighest=boothCounter[i];
			thirdPlace=i+1;
			}
		}

		// display 1
		System.out.println("\nBest Booth:\n");
		System.out.println("1st Place: Booth " + firstPlace + " with " + firstHighest + " votes!");
		System.out.println("2nd Place: Booth " + secondPlace + " with " + secondHighest + " votes!");
		System.out.println("3rd Place: Booth " + thirdPlace + " with " + thirdHighest + " votes!");

		// display 2
		// loop over array of names and blocks
		System.out.println("\nRegistered Names and Block:\n");
		for(int i=0; i<10; i++){
			System.out.println("Name: " + name[i]);
			System.out.println("Block: " + block[i] + "\n");
		}

		// ...
		// arrays to count votes by year level
		int[] firstYearBooths = new int[10];
        		int[] secondYearBooths = new int[10];
        		int[] thirdYearBooths = new int[10];
       		int[] fourthYearBooths = new int[10];

		// for loop to count votes for each booth by year level
		for (int i=0; i<bestBooth.length; i++) {
			int boothIndex=bestBooth[i]-1;

			if (yearLvl[i]==1) firstYearVotes[boothIndex]++;
			else if (yearLvl[i]==2) secondYearVotes[boothIndex]++;
			else if (yearLvl[i]==3) thirdYearVotes[boothIndex]++;
			else if (yearLvl[i]==4) fourthYearVotes[boothIndex]++;
		}

		// find best booth for first year
		int firstYearBest=0;
		int firstYearMaxVotes=-1;
		for (int i=0; i<firstYearVotes.length; i++) {
			if (firstYearVotes[i]>firstYearMaxVotes) {
				firstYearMaxVotes=firstYearVotes[i];
                			firstYearBest=i;
            }
		}

		// find best booth for second year
		int secondYearBest=0;
		int secondYearMaxVotes=-1;
		for (int i=0; i<secondYearVotes.length; i++) {
			if (secondYearVotes[i]>secondYearMaxVotes) {
				secondYearMaxVotes=secondYearVotes[i];
                			secondYearBest=i;
            }
		}

		// find best boot for third year
		int thirdYearBest=0;
		int thirdYearMaxVotes=-1;
		for (int i=0; i<thirdYearVotes.length; i++) {
			if (thirdYearVotes[i]>thirdYearMaxVotes) {
				thirdYearMaxVotes=thirdYearVotes[i];
                			thirdYearBest=i;
            }
		}

		// find best booth for fourth year
		int fourthYearBest=0;
		int fourthYearMaxVotes=-1;
		for (int i=0; i<fourthYearVotes.length; i++) {
			if (fourthYearVotes[i]>fourthYearMaxVotes) {
				fourthYearMaxVotes=fourthYearVotes[i];
                			fourthYearBest=i;
            }
		}

		// display 3
		System.out.println("\nBest Booths by Year Level:\n");
		System.out.println("1st Year Best Booth Number: " + firstYearBest);
		System.out.println("2nd Year Best Booth Number: " + secondYearBest);
		System.out.println("3rd Year Best Booth Number: " + thirdYearBest);
		System.out.println("4th Year Best Booth Number: " + fourthYearBest);
	}
}
