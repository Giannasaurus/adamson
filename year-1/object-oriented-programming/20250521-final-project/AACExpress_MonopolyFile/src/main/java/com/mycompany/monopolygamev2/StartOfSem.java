/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;

/**
 *
 * @author ysabelle
 */
public class StartOfSem extends Property {
    private static final int ALLOWANCE = 200; // The allowance given when passing the tile

    public StartOfSem() {
        super("Start of Semester", 0);
    }

    @Override
    public void action(Player player) {
        int currentPosition = player.getPosition();
        if (currentPosition == 0) {
            player.receive(ALLOWANCE); // Give them $200
            sendDialogue(player.getName() + " passed the Start of Semester and received $" + ALLOWANCE);
        }
    }
}
