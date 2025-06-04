/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;

/**
 *
 * @author ysabelle
 */
public class HourVacant extends Property {
    public HourVacant() {
        super("Hour Vacant", 0);
    }

    @Override
    public void action(Player player) {
        // sana di nlng pumasok kung vacant - ysa
        System.out.println(player.getName() + " has relaxed at Hour Vacant (free parking).");
    }
}
