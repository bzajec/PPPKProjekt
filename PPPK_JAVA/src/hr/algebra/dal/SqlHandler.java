/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hr.algebra.dal;

import hr.algebra.model.Vozac;
import hr.algebra.model.Vozilo;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.List;
import javax.sql.DataSource;

/**
 *
 * @author Bruno
 */
public class SqlHandler {
    
    private static final String INSERT_VOZILA = "INSERT INTO Vozilo (TipVozila, MarkaVozila, GodinaProizvodnje, InicijalnoStanjeKilometara) VALUES (?, ?, ?, ?)";
    private static final String INSERT_VOZACI = "INSERT INTO Vozac (Name, BrojMobitela, BrojVozackeDozvole) VALUES (?, ?, ?)";
    
    public static void insertVozilo(List<Vozilo> vozila, int kolicinaVozila) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                PreparedStatement stmt = con.prepareStatement(INSERT_VOZILA)) {

            int counter = 0;
            for (Vozilo vozilo : vozila) {
                stmt.setString(1, vozilo.getTipVozila());
                stmt.setString(2, vozilo.getMarkaVozila());
                stmt.setInt(3, vozilo.getGodinaProizvodnje());
                stmt.setInt(4, vozilo.getInicijalnoStanjeKilometara());
                stmt.addBatch();
                if (++counter == kolicinaVozila) {
                    stmt.executeBatch();
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    
    public static void insertVozac(List<Vozac> vozaci, int kolicinaVozaca) {
        DataSource dataSource = DataSourceSingleton.getInstance();
        try (Connection con = dataSource.getConnection();
                PreparedStatement stmt = con.prepareStatement(INSERT_VOZACI)) {

            int counter = 0;
            for (Vozac vozac : vozaci) {
                stmt.setString(1, vozac.getName());
                stmt.setInt(2, vozac.getBrojMobitela());
                stmt.setInt(3, vozac.getBrojVozackeDozvole());
                stmt.addBatch();
                if (++counter == kolicinaVozaca) {
                    stmt.executeBatch();
                    counter = 0;
                }
            }
            if (counter > 0) {
                stmt.executeBatch();
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
