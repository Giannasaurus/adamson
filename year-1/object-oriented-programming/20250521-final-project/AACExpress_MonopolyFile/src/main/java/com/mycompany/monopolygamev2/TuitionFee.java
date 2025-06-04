/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;

/**
 *
 * @author ysabelle
 */
public class TuitionFee extends Property{
    private int feeAmount;

    public TuitionFee(String name, int feeAmount) {
        super(name, feeAmount); //basically this is supposed to be 60000 but it will make the game shorter so yeah....
        this.feeAmount = feeAmount;
    }

    @Override
    public void action(Player player) {
        player.pay(feeAmount);
        sendDialogue(player.getName() + " paid $" + feeAmount + " in tuition fees.");
    }
}

