/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.monopolygamev2;

/**
 *
 * @author ysabelle
 */
public class Tile {
    private String name;
    private String color;

    public Tile(String name, String color) {
        this.name = name;
        this.color = color;
    }

    public String getName() {
        return name;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color; //for setting up the board (now this aint useful nor included cause its USELESSSSSS because it didnt work +>
    }
}

