/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;

import java.util.function.Consumer;

/**
 *
 * @author ysabelle
 */
public abstract class Property { //general abstract inheritance from all sub classses
    protected Consumer<String> dialogueHandler;
    protected String name;
    protected int price;
    protected Player owner;
    
    public boolean purchase(Player player) {
    if (owner == null && player.getMoney() >= price) {
        owner = player;  // Set the owner
        player.pay(price); // if plot been purchased
        player.addOwnedProperty(this);  // Add property to player's owned list
        sendDialogue(player.getName() + " bought " + name + " for $" + price + ".");
        return true;
    } else if (owner != null) {
        sendDialogue("This property is already owned by " + owner.getName() + ".");
    } else {
        sendDialogue(player.getName() + " doesn't have enough money to purchase this property.");
    }
    return false;
    }
    
    public Property(String name, int price) {
        this.name = name;
        this.price = price;
        this.owner = null;
    }
    public void setDialogueHandler(Consumer<String> dialogueHandler) {
    this.dialogueHandler = dialogueHandler;
    }

    protected void sendDialogue(String msg) {
        if (dialogueHandler != null) {
            dialogueHandler.accept(msg);
        }
    }

    public abstract void action(Player player);

    public int getPrice() { return price; }
    public String getName() { return name; }

    public void setOwner(Player p) { this.owner = p; }
    public Player getOwner() { return owner; }
    
    
}
