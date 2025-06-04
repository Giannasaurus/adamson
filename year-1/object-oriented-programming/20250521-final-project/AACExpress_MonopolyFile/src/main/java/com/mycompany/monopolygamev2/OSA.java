/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;

/**
 *
 * @author ysabelle
 */
public class OSA extends Property{
    public OSA() {
        super("Office of Student Affairs", 0);
    }

    @Override
    public void action(Player player) {
        System.out.println(player.getName() + " is currently in the Office of Student Affairs. Take a break!");
        //this is literally suspension rip.
    }
}
