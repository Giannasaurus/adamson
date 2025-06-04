/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;

/**
 *
 * @author ysabelle
 */
public class ClubProperty extends Property{
    private int rent;
    private int level;  // Level for upgrades
    private final int maxLevel = 3;

    public ClubProperty(String name, int price, int rent) {
        super(name, price);
        this.rent = rent;
        this.level = 1;
    }

    @Override
    public void action(Player player) {
        if (owner == null) {
            sendDialogue("This club is unowned. You can buy it!");
        } else if (owner == player) {
            sendDialogue("Welcome back to your club! You can upgrade it.");
        } else {
            sendDialogue("This club is owned by " + owner.getName() + ". You must pay rent.");
            int rentAmount = calculateRent();
            player.pay(rentAmount);  // Player pays rent
            owner.receive(rentAmount);  // Owner receives the rent
        }
    }

    // Rent calculation logic
    public int calculateRent() {
        return rent * level;  // Rent increase when leveld up
    }

    public boolean canUpgrade(Player player) {
        return owner == player && level < maxLevel;
    }

    public boolean upgrade(Player player) {
        if (canUpgrade(player)) {
            level++;
            rent += 50;  // Rent increases by 50
            sendDialogue(player.getName() + " upgraded " + name + " to level " + level + ". Rent is now $" + rent + ".");
            return true;
        }
        return false;
    }
    //getter and setter
    public int getLevel() {
        return level;
    }

    public int getRent() {
        return rent;
    }
}
