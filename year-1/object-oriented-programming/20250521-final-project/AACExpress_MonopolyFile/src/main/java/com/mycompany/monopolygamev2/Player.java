/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;

import java.util.*;

/**
 *
 * @author ysabelle
 */
public class Player {
    private String name;
    private int money;
    private ArrayList<Property> ownedProperties;
    private int position;
    private int osaTurns = 0;
    private boolean skipNextTurn;
    private boolean bankrupt;

    public Player(String name, int startingMoney) {
        this.name = name;
        this.money = startingMoney;
        this.ownedProperties = new ArrayList<>();
        this.position = 0;
        this.skipNextTurn = false;
        this.bankrupt = false;
    }

    public Player(String name) {
    this(name, 1500); // Default starting money
}

    public void move(int steps) {
        position = (position + steps) % 20;
        System.out.println(name + " moves to position " + position);
    }

    public void receive(int amount) {
        money += amount;
        System.out.println(name + " receives $" + amount + ". Current balance: $" + money);
    }

    public void pay(int amount) {
        if (amount > money) {
            declareBankruptcy();
        } else {
            money -= amount;
        }
    }
    
    private void declareBankruptcy() { // Basically bankrupt na yung player
        System.out.println(name + " has gone bankrupt!");
        bankrupt = true;
        money = 0; 
        ownedProperties.clear(); 
    }
    
    public boolean isBankrupt() {
        return bankrupt;
    }
    //All Getters and Setters Below
    public String getName() {
        return name;
    }

    public int getMoney() {
        return money;
    }

    public List<Property> getOwnedProperties() {
        return ownedProperties;
    }
    
    public void addOwnedProperty(Property property) {
        this.ownedProperties.add(property);
    }

    public int getPosition() {
        return position;
    }

    public void setPosition(int position) {
        this.position = position;
    }

    public void skipNextTurn() {
        skipNextTurn = true;
        System.out.println(name + " is stressed out! They will skip their next turn.");
    }

    public boolean shouldSkipTurn() {
        return osaTurns > 0 || skipNextTurn;
    }

    public void endTurn() {
        if (osaTurns > 0) {
        osaTurns--;
        if (osaTurns == 0) {
            System.out.println(name + " has served their OSA time and is now free.");
        } else {
            System.out.println(name + " is still in OSA for " + osaTurns + " more turn(s).");
        }
    }

    if (skipNextTurn) {
        System.out.println(name + " skipped a turn due to stress.");
        skipNextTurn = false;
    }
    }

    public void sendToOSA() {
        this.position = 10; //sends player to tile 10 which is OSA
        this.osaTurns = 1;
        System.out.println(name + " has been sent to the Office of Student Affairs and must skip " + osaTurns + " turn(s).");
    }
}
