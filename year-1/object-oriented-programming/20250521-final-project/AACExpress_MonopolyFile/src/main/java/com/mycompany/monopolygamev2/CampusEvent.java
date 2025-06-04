/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;
import java.util.Random;
/**
 *
 * @author ysabelle
 */


public class CampusEvent extends Property {
    private static final Random random = new Random();

    public CampusEvent(String name) {
        super(name, 0); 
    }

    @Override
    public void action(Player player) {
        int eventIndex = random.nextInt(11);

        switch (eventIndex) {
            case 0:
                handleScholarship(player);
                break;
            case 1:
                handleFine(player);
                break;
            case 2:
                handleInternship(player);
                break;
            case 3:
                handleExamFailure(player);
                break;
            case 4:
                handleDonation(player);
                break;
            case 5:
                handleGrant(player);
                break;
            case 6:
                handleBonus(player);
                break;
            case 7:
                handleLateRegistration(player);
                break;
            case 8:
                handleEmergencyFunds(player);
                break;
            case 9:
                handlePartTimeJob(player);
                break;
            case 10:
                handleStressEvent(player);
                break;
            default:
                break;
        }
    }

    // Event Methods:
    private void handleScholarship(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " won a scholarship! Receive $" + amount);
        player.receive(amount);
    }

    private void handleFine(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " got fined for breaking campus rules! Pay $" + amount);
        player.pay(amount);
    }

    private void handleInternship(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " got an internship! Receive $" + amount);
        player.receive(amount);
    }

    private void handleExamFailure(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " failed an exam! Pay $" + amount + " for retake fee.");
        player.pay(amount);
    }

    private void handleDonation(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " donated to charity! Pay $" + amount);
        player.pay(amount);
    }

    private void handleGrant(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " received a campus grant! Receive $" + amount);
        player.receive(amount);
    }

    private void handleBonus(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " received a bonus for good grades! Receive $" + amount);
        player.receive(amount);
    }

    private void handleLateRegistration(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " were fined for late registration! Pay $" + amount);
        player.pay(amount);
    }

    private void handleEmergencyFunds(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " received emergency funds! Receive $" + amount);
        player.receive(amount);
    }

    private void handlePartTimeJob(Player player) {
        int amount = randomAmount();
        sendDialogue(player.getName() + " got a part-time campus job! Receive $" + amount);
        player.receive(amount);
    }

    // Stress event - skip turn
    private void handleStressEvent(Player player) {
        sendDialogue("Stress is real! Skip a turn and rest.");
        player.skipNextTurn(); // Correct method to set the skip turn flag
    }

    // Helper method to generate random amount (between $10 and $100)
    private int randomAmount() {
        return (random.nextInt(10) + 1) * 10; // Random amount between $10 and $100
    }
}


