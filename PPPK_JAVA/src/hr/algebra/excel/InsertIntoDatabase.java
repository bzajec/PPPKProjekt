/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.excel;

import hr.algebra.dal.SqlHandler;
import hr.algebra.model.Vozac;
import hr.algebra.model.Vozilo;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

/**
 *
 * @author Bruno
 */
public class InsertIntoDatabase {

    
    public static void main(String[] args) {
        
        String vozacFileName = "vozaci.csv";
        List<Vozac> vozaci = new ArrayList<>();
        try (Stream<String> lajne = Files.lines(Paths.get(vozacFileName))) {
            List<List<String>> values = lajne.map(line -> Arrays.asList(line.split(","))).collect(Collectors.toList());
            values.forEach(value -> {
                value.forEach(line -> {
                    vozaci.add(Vozac.ParseFromCSV(line));
                });
            });
        } catch (IOException e) {
            e.printStackTrace();
        }
        SqlHandler.insertVozac(vozaci, 100);

        String vozilaFileName = "vozila.csv";
        List<Vozilo> vozila = new ArrayList<>();
        try (Stream<String> lajne = Files.lines(Paths.get(vozilaFileName))) {
            List<List<String>> values = lajne.map(line -> Arrays.asList(line.split(","))).collect(Collectors.toList());
            values.forEach(value -> {
                value.forEach(line -> {
                    vozila.add(Vozilo.ParseFromCSV(line));
                });
            });
        } catch (IOException e) {
            e.printStackTrace();
        }
        SqlHandler.insertVozilo(vozila, 100);
        
    }
    
}
