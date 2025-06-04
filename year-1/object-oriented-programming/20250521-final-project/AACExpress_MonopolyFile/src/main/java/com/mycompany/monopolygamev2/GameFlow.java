/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;
import java.util.*;
import java.util.function.Consumer;

/**
 *
 * @author ysabelle
 */
public class GameFlow {
    private List<Player> players;
    private Property[] board;
    private int currentPlayerIndex=0;
    private Random dice;
    private Player currentPlayer; 
    private Consumer<String> dialogueHandler;
    

    public static final int BOARD_SIZE = 20;

    public GameFlow(List<String> playerNames, Consumer<String> dialogueHandler) {
        this.players = new ArrayList<>();
        this.board = new Property[BOARD_SIZE]; // Initialize the board with BOARD_SIZE
        this.dice = new Random();
        this.currentPlayerIndex = 0;
        this.dialogueHandler = dialogueHandler;
        
players = new ArrayList<>();
    for (String name : playerNames) {
        players.add(new Player(name));  // Make sure the Player constructor is correctly creating a Player object
    }

    currentPlayer = players.get(0);

        setupBoard();
    }
    
    // Set up all the tiles on the board
    private void setupBoard() {
    // Set up the properties on the board
    board[0] = new StartOfSem();  // Start of Semester tile
    board[1] = new ClubProperty("Adu Cats", 200, 50);
    board[2] = new CampusEvent("Scholarship Event");
    board[3] = new CampusEvent("Fine Event");
    board[4] = new ClubProperty("Tinik ng Teatro (TNT)", 300, 75);
    board[5] = new ClubProperty("AdU-SAOrganization", 250, 60);
    board[6] = new ClubProperty("HIMIG Organization", 220, 55);
    board[7] = new GoToOSA(); // Go to Office of Student Affairs tile
    board[8] = new ClubProperty("Adu-Cares Club", 270, 65);
    board[9] = new TuitionFee("Tuition Fee - Semester 1", 500); // Tuition fee tile
    board[10] = new OSA(); // Office of Student Affairs tile
    board[11] = new HourVacant(); // Hour Vacant tile
    board[12] = new ClubProperty("Adu-RCYC Organization", 210, 50);
    board[13] = new ClubProperty("AdU-GAME Club", 230, 55);
    board[14] = new TuitionFee("Tuition Fee - Semester 2", 500); // Tuition fee tile
    board[15] = new ClubProperty("JPIAccountants", 260, 70);
    board[16] = new ClubProperty("AUMSociety", 240, 60);
    board[17] = new ClubProperty("Hiraya AdU", 280, 75);
    board[18] = new ClubProperty("PSAU Organization", 300, 80);
    board[19] = new ClubProperty("Debate Club - Advanced", 350, 90);

    // Now we set the dialogue handler for each property
    board[0].setDialogueHandler(dialogueHandler);  // Start of Sem
    board[1].setDialogueHandler(dialogueHandler);  // Photography Club
    board[2].setDialogueHandler(dialogueHandler);  // Scholarship Event
    board[3].setDialogueHandler(dialogueHandler);  // Fine Event
    board[4].setDialogueHandler(dialogueHandler);  // Debate Club
    board[5].setDialogueHandler(dialogueHandler);  // Music Club
    board[6].setDialogueHandler(dialogueHandler);  // Art Club
    board[7].setDialogueHandler(dialogueHandler);  // Go to OSA
    board[8].setDialogueHandler(dialogueHandler);  // Theater Club
    board[9].setDialogueHandler(dialogueHandler);  // Tuition Fee - Semester 1
    board[10].setDialogueHandler(dialogueHandler); // Office of Student Affairs
    board[11].setDialogueHandler(dialogueHandler); // Free Hour (Hour Vacant)
    board[12].setDialogueHandler(dialogueHandler); // Cooking Club
    board[13].setDialogueHandler(dialogueHandler); // Writing Club
    board[14].setDialogueHandler(dialogueHandler); // Tuition Fee - Semester 2
    board[15].setDialogueHandler(dialogueHandler); // Coding Club
    board[16].setDialogueHandler(dialogueHandler); // Dance Club
    board[17].setDialogueHandler(dialogueHandler); // Chess Club
    board[18].setDialogueHandler(dialogueHandler); // Photography Club - Advanced
    board[19].setDialogueHandler(dialogueHandler); // Debate Club - Advanced
}
    // Move the player and trigger tile action
    public void movePlayer(int steps) {
    Player player = getCurrentPlayer();
    int oldPos = player.getPosition();
    int newPos = (oldPos + steps) % BOARD_SIZE;

    // Pass Start of Sem check
    if (newPos < oldPos) {
        player.receive(200);
        sendDialogue(player.getName() + " passed Start of Semester! +$200 allowance");
    }

    player.setPosition(newPos);

    Property tile = getTileAt(newPos);
    sendDialogue(player.getName() + " landed on " + tile.getName());

    // The tile should trigger its own logic
    tile.action(player);

    // Additional dialogue if necessary
    if (tile instanceof GoToOSA) {
        sendDialogue(player.getName() + " is going to the Office of Student Affairs.");
        player.sendToOSA(); // You might already have a dialogue inside this method
    }
    }

    // Method to send player to OSA (Office of Student Affairs)
    public void sendPlayerToOSA(Player player) {
        player.setPosition(10);  // Assuming OSA is at position 10
        player.receive(-100);  // Example: lose money if sent to OSA
        System.out.println(player.getName() + " has been sent to the Office of Student Affairs and will miss a turn.");
    }

    // Get current player
    public Player getCurrentPlayer() {
        if (currentPlayer == null) {
        System.out.println("Error: Current player is null.");
    }
    return currentPlayer;
    }

    // Advance to the next player
    public void endTurn() {
        Player player = getCurrentPlayer();
        player.endTurn(); // Handle skipping turn logic

        currentPlayerIndex = (currentPlayerIndex + 1) % players.size();
        currentPlayer = players.get(currentPlayerIndex);
    }

    public Property getTileAt(int position) {
        return board[position];
    }
    
    public Property getCurrentTile() {
    // Assuming the player's position on the board is a number (0-19 for example)
    int position = currentPlayer.getPosition();
    
    // Return the tile at that position on the board
    if (position >= 0 && position < board.length) {  // Use board.length for arrays
        return board[position];  // Access the tile at the given position
        
    }
    return null;  // In case the position is invalid (just for safety)
}
    
    private void sendDialogue(String message) {
        if (dialogueHandler != null) {
            dialogueHandler.accept(message);
        }
    }
    public int[] rollDice() {
    int die1 = dice.nextInt(6) + 1; // 1 to 6
    int die2 = dice.nextInt(6) + 1; // 1 to 6
    return new int[] { die1, die2 };
    }
    public List<Player> getPlayers() {
    return players;
}
}
