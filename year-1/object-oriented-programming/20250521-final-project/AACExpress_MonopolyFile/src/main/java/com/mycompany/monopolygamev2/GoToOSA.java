/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;

/**
 *
 * @author ysabelle
 */
    public class GoToOSA extends Property {
    public GoToOSA() {
        super("Office of Student Affairs", 0); // No price for OSA
    }

    @Override
    public void action(Player player) {
        player.setPosition(0); //Move player back to OSA
        sendDialogue(player.getName() + " has been sent to the Office of Student Affairs.");

        // Skip the player's next turn
        player.skipNextTurn();
        sendDialogue(player.getName() + " will skip their next turn.");
    }
}
